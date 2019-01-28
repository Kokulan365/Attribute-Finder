using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using AttributeFinder.Model;
using XrmToolBox.Extensibility.Args;

namespace AttributeFinder
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        private readonly List<ListViewItem> fullListOfAttributes = new List<ListViewItem>();

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void WhoAmI()
        {
            Service.Execute(new WhoAmIRequest());
        }
        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            //ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            ExecuteMethod(WhoAmI);

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;


        private void tsbClose_Click_1(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsb_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadAttributes);
        }

        public void LoadAttributes()
        {
            lvAttributes.Items.Clear();
            lvAttributes.Enabled = false;
            tsbClose.Enabled = false;
            tsbLoadAttributes.Enabled = false;

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading attributes please wait...",
                Work = (w, e) =>
                {
                    e.Result = Helpers.MetaDataHelper.LoadAttributes(Service);
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(e.Error.ToString());
                    }

                    //var items = new List<ListViewItem>();
                    fullListOfAttributes.AddRange((List<ListViewItem>)e.Result);

                    //foreach (var emd in items)
                    //{
                    //    var item = new ListViewItem(emd.DisplayName.UserLocalizedLabel != null
                    //        ? emd.DisplayName.UserLocalizedLabel.Label
                    //        : "N/A");
                    //    item.SubItems.Add(emd.LogicalName);
                    //    item.Tag = emd;


                    //    allItems.Add(item);

                    //    if (txtSearch.Text.Length == 0 || txtSearch.Text.Length > 0
                    //        && (emd.LogicalName.IndexOf(txtSearch.Text.ToLower(), StringComparison.Ordinal) >= 0
                    //            || emd.DisplayName?.UserLocalizedLabel?.Label.ToLower()
                    //                .IndexOf(txtSearch.Text.ToLower(), StringComparison.Ordinal) >= 0))
                    //    {
                    //        items.Add(item);
                    //    }
                    //}

                    MessageBox.Show("Total number of Items : " + fullListOfAttributes.Count);


                    lvAttributes.Items.AddRange(fullListOfAttributes.ToArray());
                    lvAttributes.Enabled = true;
                    tsbClose.Enabled = true;
                    tsbLoadAttributes.Enabled = true;
                },
                ProgressChanged = e =>
                {
                    SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(e.UserState.ToString()));
                }
            });
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //lvAttributes.SelectedIndexChanged -= lvEntities_SelectedIndexChanged;
           

           // lvEntities.SelectedIndexChanged += lvEntities_SelectedIndexChanged;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            lvAttributes.Items.Clear();

            if (txtSearch.Text.Length == 0)
            {
                lvAttributes.Items.AddRange(fullListOfAttributes.ToArray());
            }
            else
            {
                lvAttributes.Items.AddRange(fullListOfAttributes
                    .Where(i => ((AttributeViewModel)i.Tag).LogicalName.IndexOf(txtSearch.Text.ToLower()) >= 0).ToArray());

                //lvAttributes.Items.AddRange(fullListOfAttributes
                //    .Where(i => ((AttributeViewModel)i.Tag).LogicalName.IndexOf(txtSearch.Text.ToLower()) >= 0
                //                || ((AttributeViewModel)i.Tag).DisplayName.IndexOf(txtSearch
                //                    .Text.ToLower()) >= 0).ToArray());
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;

                lvAttributes.Items.Clear();

                if (txtSearch.Text.Length == 0)
                {
                    lvAttributes.Items.AddRange(fullListOfAttributes.ToArray());
                }
                else
                {
                    var itemsFound = fullListOfAttributes
                        .Where(i => ((AttributeViewModel)i.Tag).LogicalName.IndexOf(txtSearch.Text.ToLower()) >= 0).ToArray();

                    if (itemsFound.Any())
                    {
                        lvAttributes.Items.AddRange(itemsFound);
                    }
                    else
                    {
                        MessageBox.Show($"No attributes found with the search term : {txtSearch.Text}");

                    }


                    //lvAttributes.Items.AddRange(fullListOfAttributes
                    //    .Where(i => ((AttributeViewModel)i.Tag).LogicalName.IndexOf(txtSearch.Text.ToLower()) >= 0
                    //                || ((AttributeViewModel)i.Tag).DisplayName.IndexOf(txtSearch
                    //                    .Text.ToLower()) >= 0).ToArray());
                }

            }
        }
    }
}