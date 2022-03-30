using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;


namespace ADtoolv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            debugView.Text += "User: " + userName.Text + ", Pass: " + password.Text +", Dom: " + domain.Text + "\n";
            debugView.SelectionStart = debugView.Text.Length;
            debugView.ScrollToCaret();
            try
            {

                DirectoryEntry de = new DirectoryEntry("LDAP://" + domain.Text, userName.Text, password.Text);
                if(de.Properties.Count > 0)
                {
                    debugView.Text += "connected to " + domain.Text + " as " + userName.Text + "\n";
                    object o = de.NativeObject;
                }
            }
            catch (System.Runtime.InteropServices.COMException comex)
            {
                debugView.Text += comex;
            }
            
            
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            //userInfo.Text += txtUserSearch.Text + "\n";
            userInfo.Clear();
            txtboxusergroups.Clear();

            DirectoryEntry de = new DirectoryEntry("LDAP://" + domain.Text, userName.Text, password.Text);
            DirectorySearcher ds = new DirectorySearcher(de);
            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(samaccountname=" + txtUserSearch.Text + "))";
            ds.SearchScope = SearchScope.Subtree;
            SearchResult rs = ds.FindOne();

            if(cboxsamaccount.Checked == true && rs.GetDirectoryEntry().Properties["samaccountname"].Value != null)
            {
                debugView.Text += "getting sam account\n";
                userInfo.Text += "Sam Account: " + rs.GetDirectoryEntry().Properties["samaccountname"].Value.ToString() + "\n";
            }

            if (cboxemail.Checked == true && rs.GetDirectoryEntry().Properties["mail"].Value != null)
            {
                debugView.Text += "getting email account\n";
                userInfo.Text += "email: " + rs.GetDirectoryEntry().Properties["mail"].Value.ToString() + "\n";
            }

            if (cboxdisc.Checked == true && rs.GetDirectoryEntry().Properties["description"].Value != null)
            {
                debugView.Text += "getting description account\n";
                userInfo.Text += "Description: " + rs.GetDirectoryEntry().Properties["description"].Value.ToString() + "\n";
            }

            if (cboxdisplayname.Checked == true && rs.GetDirectoryEntry().Properties["displayname"].Value != null)
            {
                debugView.Text += "getting diplay name account\n";
                userInfo.Text += "display name: " + rs.GetDirectoryEntry().Properties["displayname"].Value.ToString() + "\n";
            }

            if (cboxphone.Checked == true && rs.GetDirectoryEntry().Properties["mobile"].Value != null)
            {
                debugView.Text += "getting mobile phone account\n";
                userInfo.Text += "mobile phone: " + rs.GetDirectoryEntry().Properties["mobile"].Value.ToString() + "\n";
            }

            if (cboxiphone.Checked == true && rs.GetDirectoryEntry().Properties["ipphone"].Value != null)
            {
                debugView.Text += "getting ip phone account\n";
                userInfo.Text += "ip phone: " + rs.GetDirectoryEntry().Properties["ipphone"].Value.ToString() + "\n";
            }

            if (cboxpager.Checked == true && rs.GetDirectoryEntry().Properties["pager"].Value != null)
            {
                debugView.Text += "getting pager account\n";
                userInfo.Text += "pager: " + rs.GetDirectoryEntry().Properties["pager"].Value.ToString() + "\n";
            }

            if (cboxoffice.Checked == true && rs.GetDirectoryEntry().Properties["physicalDeliveryOfficeName"].Value != null)
            {
                debugView.Text += "getting office account\n";
                userInfo.Text += "office: " + rs.GetDirectoryEntry().Properties["physicalDeliveryOfficeName"].Value.ToString() + "\n";
            }

            if (cboxcompany.Checked == true && rs.GetDirectoryEntry().Properties["company"].Value != null)
            {
                debugView.Text += "getting company account\n";
                userInfo.Text += "company: " + rs.GetDirectoryEntry().Properties["company"].Value.ToString() + "\n";
            }

            if (cboxlogonCount.Checked == true && rs.GetDirectoryEntry().Properties["logonCount"].Value != null)
            {
                debugView.Text += "getting logonCount account\n";
                userInfo.Text += "logonCount: " + rs.GetDirectoryEntry().Properties["logonCount"].Value.ToString() + "\n";
            }

            //need to check if this is correct
            if (cboxAccEnabled.Checked == true)
            {
                debugView.Text += "getting accountEnabled account\n";
                int userAccountControl = Convert.ToInt32(rs.Properties["userAccountControl"][0]);
                bool disabled = ((userAccountControl & 2) > 0);
                userInfo.Text += "is Disabled: " + disabled.ToString() + "\n";
            }

            if (cboxlastlogoff.Checked == true && rs.GetDirectoryEntry().Properties["lastlogoff"].Value != null)
            {
                debugView.Text += "getting last logoff account\n";
                //userInfo.Text += rs.GetDirectoryEntry().Properties["lastlogoff"].Value.ToString() + "\n";
                long dtLogoff = (long)rs.Properties["lastlogoff"][0];
                var dt1Logoff = new DateTime(1601, 01, 01, 0, 0, 0, DateTimeKind.Utc).AddTicks(dtLogoff);
                userInfo.Text += "Last logoff: " + dt1Logoff + "\n";
            }

            if (cboxlastlogon.Checked == true && rs.GetDirectoryEntry().Properties["lastlogon"].Value != null)
            {
                debugView.Text += "getting last logon account\n";
                //userInfo.Text += "last logon: " + rs.GetDirectoryEntry().Properties["lastlogon"].Value.ToString() + "\n";
                long dtLogon = (long)rs.Properties["lastlogon"][0];
                var dt1Logon = new DateTime(1601, 01, 01, 0, 0, 0, DateTimeKind.Utc).AddTicks(dtLogon);
                userInfo.Text += "Last logon: " + dt1Logon + "\n";
            }

            if (cboxlastlogontimestamp.Checked == true && rs.GetDirectoryEntry().Properties["lastlogontimestamp"].Value != null)
            {
                debugView.Text += "getting last logon timestamp account\n";
                //userInfo.Text += "last logon timestamp: " + rs.GetDirectoryEntry().Properties["lastlogontimestamp"].Value.ToString() + "\n";
                long dtLogonTimeStamp = (long)rs.Properties["lastlogontimestamp"][0];
                var dt1LogonTimestamp = new DateTime(1601, 01, 01, 0, 0, 0, DateTimeKind.Utc).AddTicks(dtLogonTimeStamp);
                userInfo.Text += "Last logon timestamp: " + dt1LogonTimestamp + "\n";
            }

            if (cboxusergroups.Checked == true)
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain, domain.Text), IdentityType.SamAccountName, txtUserSearch.Text);
                foreach(GroupPrincipal group in user.GetGroups())
                {
                    txtboxusergroups.Text += group + "\n";
                }
            }

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
