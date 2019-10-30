using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PortlandTripper.Models
{
    public class TripAdvisor
    {
        public int TripAdvisorId {get; set;}
        [Required]
        [StringLength(20)]
        public string Name {get; set;}
        [Required]
        [StringLength(20)]

        public string Hours {get; set;}
        [Required]
        [StringLength(100)]

        public string Address {get; set;}
        [Required]
        public int Cost {get; set;}
        [Required]
        [StringLength(500)]
        public string Description {get; set;}
        
    

    public static List<TripAdvisor> GetTrips()
        {
            var apiCallTask = ApiHelper.ApiCall();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            Console.WriteLine(jsonResponse);
            List<TripAdvisor> tripAdvisorList = JsonConvert.DeserializeObject<List<TripAdvisor>>(jsonResponse.ToString());

            return tripAdvisorList;
        }
    }
}