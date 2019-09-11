using System;

namespace BestPractices.Common
{
    static public class NotificationServices
    {
        /// <summary>
        /// Notifies Talent
        /// </summary>
        /// <param name="talentName"></param>
        /// <returns></returns>
        static public string NotifyTalent(string talentName)
        {
            var message = $"Notifying talent: {talentName}";
            Console.WriteLine(message);
            return message;
        }
    }
}
