using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractices
{
    public class Actor
    {
        //public Actor()
        //{
        //    this.CurrentAgency = new Agency();
        //}


        public Actor()
        {

        }

        public Actor(string actorName)
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set
            {
                var formatedName = value?.Trim();
                actorName = formatedName;
            }
        }


        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public int ActorAge { get; set; }

        public string ActorDescription { get; set; } = "Regular actor";

        private Agency currentAgency;

        //public Agency CurrentAgency
        //{
        //    get { return currentAgency; }
        //    set { currentAgency = value; }
        //}

        public Agency CurrentAgency
        {
            get
            {
                if (currentAgency == null)
                {
                    currentAgency = new Agency();
                }
                return currentAgency;
            }
            set { currentAgency = value; }
        }



        /// <summary>
        /// Will return the title
        /// </summary>
        /// <returns>string</returns>
        public string GetOccupation()
        {
            jobTitle = "Actor";
            return jobTitle;
        }


        ///// <summary>
        ///// Books actor and no date specified
        ///// </summary>
        ///// <returns></returns>
        //public string BookActor()
        //{
        //    string details = $"Bookin can change if actor starts trouble";

        //    return $"Actor {ActorName} is booked. {details}";
        //}


        ///// <summary>
        ///// Books actor on specific date
        ///// </summary>
        ///// <param name="theDate"></param>
        ///// <returns></returns>
        //public string BookActor(string theDate)
        //{
        //    string details = $"Bookin can change if actor starts trouble";

        //    return $"Actor {ActorName} is booked on {theDate}. {details}";
        //}


        /// <summary>
        /// Books actor and no date specified
        /// </summary>
        /// <returns></returns>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }


        /// <summary>
        /// Books actor on specific date
        /// </summary>
        /// <param name="theDate"></param>
        /// <returns></returns>
        public string BookActor(string theDate)
        {
            string details = $"Bookin can change if actor starts trouble";
            string theActor = $"Actor {ActorName} is booked";

            if (theDate != string.Empty)
            {
                return $"{theActor} on {theDate}. {details}";
            }
            else
            {
                return $"{theActor}. {details}";
            }
        }


        //public string GetAgency()
        //{
        //    var currentAgency = new Agency();
        //    return currentAgency.Name;
        //}

        public string GetAgency()
        {
            return CurrentAgency.Name;
        }
    }
}
