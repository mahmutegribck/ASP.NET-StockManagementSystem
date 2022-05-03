using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class smsMP : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //CreateMenuControl();
    }
    private void CreateMenuControl()
    {

        menu_hr.DataSource = GetSiteMapDataSource();
        menu_hr.DataBind();
    }

    private SiteMapDataSource GetSiteMapDataSource()
    {
        XmlSiteMapProvider xmlSiteMap = new XmlSiteMapProvider();
        System.Collections.Specialized.NameValueCollection
               myCollection = new
               System.Collections.Specialized.NameValueCollection(1);
        myCollection.Add("siteMapFile", "Web.sitemap");
        xmlSiteMap.Initialize("provider", myCollection);
        xmlSiteMap.BuildSiteMap();
        SiteMapDataSource siteMap = new SiteMapDataSource();
        return siteMap;
    }
}
