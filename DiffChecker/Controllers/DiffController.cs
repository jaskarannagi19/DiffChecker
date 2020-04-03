using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Xml.Serialization;
using DiffChecker.Model;
using DiffMatchPatch;
using Microsoft.AspNetCore.Mvc;

namespace DiffChecker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiffController : ControllerBase
    {
        // GET: api/Diff
        [HttpGet]
        public IEnumerable<string> Get()
        {
            diff_match_patch dmp = new diff_match_patch();
            //List<Diff> diff = dmp.diff_main(@"This position will be responsible for the on-going management of Vertex’s contract third party logistics providers (89PLs) and commercial distributor network in Europe and internationally. In addition, this position will work closely with the Supply Chain/Pharm Ops team based in the US, the Quality team, and with the International Commercial team to synchronize drug supply with demand based on country/regional level needs.Key Responsibilities:
            //Responsible for the execution of customer service and distribution operations at 3PLs
            //Manage contracts & promote positive effective relationships between Vertex and 3PLs, distributors, wholesalers, home care providers, and transportation partners
            //Play a primary role in supply chain logistics, including product return investigations, and Customer Service team interaction to support order processing and customer Follow-ups
            //We are currently recruiting for a Site Manager to work in our Leaways School in Clapton.Leaways School provides a safe learning environment for pupils struggling with social, emotional and mental health problems(SEMH), attention deficit hyperactivity disorder(ADHD), obsessive compulsive disorder(OCD), opposition defiance disorder, conduct disorder or foetal


            //Monitor target inventory levels, track replenishments from supply sites, and support inventory reconciliation
            //Ensure Vertex logistics operations are at high service levels, GDP compliant, and cost efficient
            //Ensure appropriate process controls and documentation are in place within Vertex and at suppliers, utilizing change control platforms, SOPs, and other processes / tools
            //Support projects and launch activities for commercial programs in Europe and internationally
            //Oversee occasional stickering / packaging activity at 3PLs
            //Support supply to managed access programs and handle named patient supply requests
            //Participate in audits and support audit remediation, as needed
            //Support risk management activities related to distribution
            //Track shipping and warehouse data to produce monthly metrics and dashboards
            //Seek operational excellence and implement process improvements
            //Monitors distribution activities ex - North America, understanding complexities of channels and finding innovative solutions for supply of product to patient.
            // Key requirements:


            // Strong experience in customer services, order management and logistics for pharmaceutical product
            // Proven experience in working cross - functionally to achieve successful outcomes
            // Knowledge of Good Distribution Practice guidelines and compliant practices
            // Proven ability in working with rd party logistics providers(3PL’s)
            // Experience in export shipping requirements for destinations outside of EU desirable
            // Proven experience of managing day to day operations and issue resolution in a learings, high volume environment
            // Experience of analysing data and compiling reports
            // Used to working with the boundaries of Standard Operating Procedures
            // Knowledge of Managed Access Programmes and Named Patient Supply desirable.


            // ", @"This position will be responsible for the on-going management of Vertex’s contract third party logistics providers (89PLs) and commercial distributor network in Europe and internationally. In addition, this position will work closely with the Supply Chain/Pharm Ops team based in the US, the Quality team, and with the International Commercial team to synchronize drug supply with demand based on country/regional level needs.

            //Key Responsibilities:

            //Responsible for the execution of customer service and distribution operations at 3PLs
            //Manage contracts & promote positive effective relationships between Vertex and 3PLs, distributors, wholesalers, home care providers, and transportation partners
            //Play a primary role in supply chain logistics, including product return investigations, and Customer Service team interaction to support order processing and customer Follow-ups
            //We are currently recruiting for a Site Manager to work in our Leaways School in Clapton. Leaways School provides a safe learning environment for pupils struggling with social, emotional and mental health problems (SEMH), attention deficit hyperactivity disorder (ADHD), obsessive compulsive disorder (OCD), opposition defiance disorder, conduct disorder or foetal 

            //Monitor target inventory levels, track replenishments from supply sites, and support inventory reconciliation
            //Ensure Vertex logistics operations are at high service levels, GDP compliant, and cost efficient
            //Ensure appropriate process controls and documentation are in place within Vertex and at suppliers, utilizing change control platforms, SOPs, and other processes/tools
            //Support projects and launch activities for commercial programs in Europe and internationally
            //Oversee occasional stickering/packaging activity at 3PLs
            //Support supply to managed access programs and handle named patient supply requests
            //Participate in audits and support audit remediation, as needed
            //Support risk management activities related to distribution
            //Track shipping and warehouse data to produce monthly metrics and dashboards
            //Seek operational excellence and implement process improvements
            //Monitors distribution activities ex-North America, understanding complexities of channels and finding innovative solutions for supply of product to patient.
            //Key requirements:

            //Strong experience in customer services, order management and logistics for pharmaceutical product
            //Proven experience in working cross-functionally to achieve successful outcomes
            //Knowledge of Good Distribution Practice guidelines and compliant practices
            //Proven ability in working with rd party logistics providers (3PL’s)
            //Experience in export shipping requirements for destinations outside of EU desirable
            //Proven experience of managing day to day operations and issue resolution in a learings , high volume environment
            //Experience of analysing data and compiling reports
            //Used to working with the boundaries of Standard Operating Procedures
            //Knowledge of Managed Access Programmes and Named Patient Supply desirable.

            //");


            string originalText = @"This position will be responsible for the on-going management of Vertex’s contract third party logistics providers (3PLs) and commercial distributor network in Europe and internationally. In addition, this position will work closely with the Supply Chain/Pharm Ops team based in the US, the Quality team, and with the International Commercial team to synchronize drug supply with demand based on country/regional level needs.

Key Responsibilities:

Responsible for the execution of customer service and distribution operations at 3PLs
Manage contracts & promote positive effective relationships between Vertex and 3PLs, distributors, wholesalers, home care providers, and transportation partners
Play a primary role in supply chain logistics, including product return investigations, and Customer Service team interaction to support order processing and customer Follow-ups
Monitor target inventory levels, track replenishments from supply sites, and support inventory reconciliation
Ensure Vertex logistics operations are at high service levels, GDP compliant, and cost efficient
Ensure appropriate process controls and documentation are in place within Vertex and at suppliers, utilizing change control platforms, SOPs, and other processes/tools
Support projects and launch activities for commercial programs in Europe and internationally
Oversee occasional stickering/packaging activity at 3PLs
Support supply to managed access programs and handle named patient supply requests
Participate in audits and support audit remediation, as needed
Support risk management activities related to distribution
Track shipping and warehouse data to produce monthly metrics and dashboards
Seek operational excellence and implement process improvements
Monitors distribution activities ex-North America, understanding complexities of channels and finding innovative solutions for supply of product to patient.
Key requirements:

Strong experience in customer services, order management and logistics for pharmaceutical product
Proven experience in working cross-functionally to achieve successful outcomes
Knowledge of Good Distribution Practice guidelines and compliant practices
Proven ability in working with 3rd party logistics providers (3PL’s)
Experience in export shipping requirements for destinations outside of EU desirable
Proven experience of managing day to day operations and issue resolution in a dynamic, high volume environment
Experience of analysing data and compiling reports
Used to working with the boundaries of Standard Operating Procedures
Knowledge of Managed Access Programmes and Named Patient Supply desirable.
";


            string replacedText = @"This position will be responsible for the on-going management of Vertex’s contract third party logistics providers (89PLs) and commercial distributor network in Europe and internationally. In addition, this position will work closely with the Supply Chain/Pharm Ops team based in the US, the Quality team, and with the International Commercial team to synchronize drug supply with demand based on country/regional level needs.

Key Responsibilities:

Responsible for the execution of customer service and distribution operations at 3PLs
Manage contracts & promote positive effective relationships between Vertex and 3PLs, distributors, wholesalers, home care providers, and transportation partners
Play a primary role in supply chain logistics, including product return investigations, and Customer Service team interaction to support order processing and customer Follow-ups
We are currently recruiting for a Site Manager to work in our Leaways School in Clapton. Leaways School provides a safe learning environment for pupils struggling with social, emotional and mental health problems (SEMH), attention deficit hyperactivity disorder (ADHD), obsessive compulsive disorder (OCD), opposition defiance disorder, conduct disorder or foetal 

Monitor target inventory levels, track replenishments from supply sites, and support inventory reconciliation
Ensure Vertex logistics operations are at high service levels, GDP compliant, and cost efficient
Ensure appropriate process controls and documentation are in place within Vertex and at suppliers, utilizing change control platforms, SOPs, and other processes/tools
Support projects and launch activities for commercial programs in Europe and internationally
Oversee occasional stickering/packaging activity at 3PLs
Support supply to managed access programs and handle named patient supply requests
Participate in audits and support audit remediation, as needed
Support risk management activities related to distribution
Track shipping and warehouse data to produce monthly metrics and dashboards
Seek operational excellence and implement process improvements
Monitors distribution activities ex-North America, understanding complexities of channels and finding innovative solutions for supply of product to patient.
Key requirements:

Strong experience in customer services, order management and logistics for pharmaceutical product
Proven experience in working cross-functionally to achieve successful outcomes
Knowledge of Good Distribution Practice guidelines and compliant practices
Proven ability in working with rd party logistics providers (3PL’s)
Experience in export shipping requirements for destinations outside of EU desirable
Proven experience of managing day to day operations and issue resolution in a learings , high volume environment
Experience of analysing data and compiling reports
Used to working with the boundaries of Standard Operating Procedures
Knowledge of Managed Access Programmes and Named Patient Supply desirable.
";

            List<Diff> diff = new List<Diff>();
            List<string> results = new List<string>();

            diff = dmp.diff_main(originalText,replacedText);

            dmp.diff_cleanupSemantic(diff);


           for (int j = 0; j < diff.Count; j++)
           {
                    results.Add(diff[j].ToString());
           }
           return results;
        }

        // GET: api/Diff/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Diff
        [Consumes("application/xml")]
        [HttpPost]
        public List<string> Post([FromBody]JobModel jobList)//MAPPING CH PROBLEM
        {

            List<Diff> diff = new List<Diff>();
            List<string> result = new List<string>();
            diff_match_patch dmp = new diff_match_patch();

            string title = jobList.JobClass[0].title;
            string newTitle = jobList.JobClass[1].title;

            string oldDescription = jobList.JobClass[0].description;
            string newDescription = jobList.JobClass[1].description;
            

            diff = dmp.diff_main(title, newTitle);
            dmp.diff_cleanupSemantic(diff);

            

            for (int j = 0; j < diff.Count; j++)
            {
                  result.Add(diff[j].ToString());
            }

            //Compare description
            diff = dmp.diff_main(oldDescription, newDescription);
            dmp.diff_cleanupSemantic(diff);
            for (int j = 0; j < diff.Count; j++)
            {
                result.Add(diff[j].ToString());
            }

            return result;
        }


        //private List<string> Compare(string originalText, string newText)
        //{
        //    
            
        //    List<Diff> diff = new List<Diff>();
            
        //    List<string> results = new List<string>();

        //    diff = dmp.diff_main(originalText, newText);

        //    dmp.diff_cleanupSemantic(diff);


        //    for (int j = 0; j < diff.Count; j++)
        //    {
        //        results.Add(diff[j].ToString());
        //    }
        //    return results;
        //}
     

        // PUT: api/Diff/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
