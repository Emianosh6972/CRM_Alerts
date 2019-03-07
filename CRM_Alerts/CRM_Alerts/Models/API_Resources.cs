namespace CRM_Alerts.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class API_Resources
    {
        public enum resource
        {
            clients,
            assets,
            licenses,
            credentials,
            asset_categories,
            license_categories,
            status_labels,
            manufacturers,
            models,
            locations,
            suppliers,
            projects,
            tickets,
            ticket_replies,
            issues,
            kb_categories,
            kb_articles,
            monitoring_hosts,
            monitoring_checks,
            users,
            staff,
            roles,
            languages,
            contacts,
            comments,
            milestones,
            predefined_replies,
            custom_asset_fields,
            custom_license_fields,
            config,
            ticket_departments,
            time_log,
            system_log,
            files,
            authenticate
        }

        public class clients
        {
            public int id { get; set; }
            public string name { get; set; }
            public string asset_tag_prefix { get; set; }
            public string license_tag_prefix { get; set; }
            public string notes { get; set; }
        }
        public class assets
        {
            public int id { get; set; }
            public int categoryid { get; set; }
            public int adminid{ get; set; }
            public int clientid{ get; set; }
            public int userid { get; set; }
            public int manufacturerid { get; set; }
            public int modelid { get; set; }
            public int supplierid { get; set; }
            public int statusid { get; set; }
            public DateTime purchase_date { get; set; }
            public int warranty_months { get; set; }
            public string tag { get; set; }
            public string name { get; set; }
            public string serial { get; set; }
            public string notes { get; set; }
            public int locationid { get; set; }
            public custom_asset_fields[] customfields{ get; set; } 
            public string qrvalue { get; set; }
        }
        public class licenses
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public int statusid { get; set; }
            public int categoryid { get; set; }
            public int supplierid { get; set; }
            public string seats { get; set; }
            public string tag{ get; set; }
            public string name { get; set; }
            public string serial { get; set; }
            public string notes { get; set; }
            public custom_license_fields[] customfields { get; set; }
        }
        public class credentials
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public int assetid { get; set; }
            public string type { get; set; }
            public string username { get; set; }
            public string password { get; set; }
        }
        public class asset_categories
        {
            public int id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
        }
        public class licence_categories
        {
            public int id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
        }
        public class status_labels
        {
            public int id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
        }
        public class manufacturers
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class models
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class locations
        {
            public int id { get; set; }
            public string name { get; set; }
            public int clientid{ get; set; }
        }
        public class suppliers
        {
            public int id { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string contactname { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string web { get; set; }
            public string notes { get; set; }
        }
        public class projects
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public string tag { get; set; }
            public string name { get; set; }
            public string notes { get; set; }
            public string description { get; set; }
            public DateTime startdate { get; set; }
            public DateTime deadline { get; set; }
            public int progress { get; set; }
        }
        public class tickets
        {
            public int id { get; set; }
            public int departmentid { get; set; }
            public int clientid { get; set; }
            public int adminid { get; set; }
            public int userid { get; set; }
            public int assetid { get; set; }
            public int projectid { get; set; }
            public string email { get; set; }
            public string subject { get; set; }
            public string priority { get; set; }            // Low Normal or High
            public string notes { get; set; }
            public string[] ccs { get; set; }
            public string message { get; set; }
            public Boolean notification { get; set; }
            public string status { get; set; }              // open, in progress, answered, reopened, closed
        }
        public class ticket_replies
        {
            public int id { get; set; }
            public int ticketid { get; set; }
            public int adminid { get; set; }
            public int userid { get; set; }
            public string message { get; set; }
            public int peopleid { get; set; }
            public string status { get; set; }              // open, in progress, answered, reopened or closed, optional to change the status of a ticket after adding the reply
            public Boolean notification { get; set; }
        }
        public class issues
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public int assetid { get; set; }
            public int projectid { get; set; }
            public int adminid { get; set; }
            public string issuetype { get; set; }       // task, maintenance, bug, improvement, new feature or story
            public string priority { get; set; }        // to do, in progress, in review or done
            public string name { get; set; }
            public string description { get; set; }
            public DateTime duedate { get; set; }
        }
        public class kb_categories
        {
            public int id { get; set; }
            public clients[] clients { get; set; }
            public string name{ get; set; }
        }
        public class kb_articles
        {
            public int id { get; set; }
            public int categoryid { get; set; }
            public clients[] clients { get; set; }
            public string name { get; set; }
            public string content { get; set; }
        }



        public class custom_asset_fields
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string options { get; set; }
        }
        public class custom_license_fields
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string options { get; set; }
        }

    }
}
