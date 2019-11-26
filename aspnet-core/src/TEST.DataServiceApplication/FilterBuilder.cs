using Abp.Application.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.DataServiceApplication.Models;

namespace TEST.DataServiceApplication
{

        public class FilterBuilder : IApplicationService
        {
            public FilterDefinition<Event> GetFilterConditions(dynamic parameters)
            {
                //Select Statements
                var what = parameters["what"];
                var what_sport = what["sport"];
                var what_game = what["game"];
                var what_country = what["country"];
                var what_league = what["league"];
                var what_market = what["market"];
                var what_odd = what["odd"];
                //Conditions
                var where = parameters["where"];
                var where_sport = where["sport"];
                var where_game = where["game"];
                var where_country = where["country"];
                var where_league = where["league"];

                var game_count = false;

                FilterDefinition<Event> condition = Builders<Event>.Filter.Empty;


                return condition;

            }


        }


}
