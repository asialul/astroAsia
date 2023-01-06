using astroNerds.Models;
using astroNerds.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;


namespace astroNerds.Models.ViewModel
{
    public class BirthChartViewModel
    {
        
        
            [Required]
            public string Name { get; set; }

            [Required]
            public string Gender { get; set; }
        
            [Required]
            public string Day { get; set; }
            [Required]
            public string Month { get; set; }
            [Required]
            public string Year { get; set; }

        public enum Genders { He = 1, She, They }

        public enum Days
        {
            [Display(Name = "1")] _1 = 1,
            [Display(Name = "2")] _2,
            [Display(Name = "3")] _3,
            [Display(Name = "4")] _4,
            [Display(Name = "5")] _5,
            [Display(Name = "6")] _6,
            [Display(Name = "7")] _7,
            [Display(Name = "8")] _8,
            [Display(Name = "9")] _9,
            [Display(Name = "10")] _10,
            [Display(Name = "11")] _11,
            [Display(Name = "12")] _12,
            [Display(Name = "13")] _13,
            [Display(Name = "14")] _14,
            [Display(Name = "15")] _15,
            [Display(Name = "16")] _16,
            [Display(Name = "17")] _17,
            [Display(Name = "18")] _18,
            [Display(Name = "19")] _19,
            [Display(Name = "20")] _20,
            [Display(Name = "21")] _21,
            [Display(Name = "22")] _22,
            [Display(Name = "23")] _23,
            [Display(Name = "24")] _24,
            [Display(Name = "25")] _25,
            [Display(Name = "26")] _26,
            [Display(Name = "27")] _27,
            [Display(Name = "28")] _28,
            [Display(Name = "29")] _29,
            [Display(Name = "30")] _30,
            [Display(Name = "31")] _31,
        }
        
        public enum Months
        {
           January = 1, February, March, April, May, June, July, August, September, October, November, December
        }

        public enum Years
        {
            [Display(Name = "2000")] _2000,
            [Display(Name = "2001")] _2001,
            [Display(Name = "2002")] _2002,
            [Display(Name = "2003")] _2003,
            [Display(Name = "2004")] _2004,
            [Display(Name = "2005")] _2005,
            [Display(Name = "2006")] _2006,
            [Display(Name = "2007")] _2007,
            [Display(Name = "2008")] _2008,
            [Display(Name = "2009")] _2009,
            [Display(Name = "2010")] _2010,
            [Display(Name = "2011")] _2011,
            [Display(Name = "2012")] _2012,
            [Display(Name = "2013")] _2013,
            [Display(Name = "2014")] _2014,
            [Display(Name = "2015")] _2015,
            [Display(Name = "2016")] _2016,
            [Display(Name = "2017")] _2017,
            [Display(Name = "2018")] _2018,
            [Display(Name = "2019")] _2019,
            [Display(Name = "2029")] _2020,
            [Display(Name = "2021")] _2021,
            [Display(Name = "2022")] _2022,
            [Display(Name = "2023")] _2023,
        }


    }   
}

//public List<SelectListItem> Genders { get; } = new List<SelectListItem>
//{
//new SelectListItem { Value = "He", Text = "He" },
//new SelectListItem { Value = "She", Text = "She" },
//new SelectListItem { Value = "They", Text = "They"  },
// };

//public List<SelectListItem> Days { get; set; } = new List<SelectListItem>
//{
//    new SelectListItem {Value = "1", Text = "1"},
//    new SelectListItem {Value = "2", Text = "2"},
//    new SelectListItem {Value = "3", Text = "3"},
//    new SelectListItem {Value = "4", Text = "4"},
//    new SelectListItem {Value = "5", Text = "5"},
//    new SelectListItem {Value = "6", Text = "6"},
//    new SelectListItem {Value = "7", Text = "7"},
//    new SelectListItem {Value = "8", Text = "8"},
//    new SelectListItem {Value = "9", Text = "9"},
//    new SelectListItem {Value = "10", Text = "10"},
//    new SelectListItem {Value = "11", Text = "11"},
//    new SelectListItem {Value = "12", Text = "12"},
//    new SelectListItem {Value = "13", Text = "13"},
//    new SelectListItem {Value = "14", Text = "14"},
//    new SelectListItem {Value = "15", Text = "15"},
//    new SelectListItem {Value = "16", Text = "16"},
//    new SelectListItem {Value = "17", Text = "17"},
//    new SelectListItem {Value = "18", Text = "18"},
//    new SelectListItem {Value = "19", Text = "19"},
//    new SelectListItem {Value = "20", Text = "20"},
//    new SelectListItem {Value = "21", Text = "21"},
//    new SelectListItem {Value = "22", Text = "22"},
//    new SelectListItem {Value = "23", Text = "23"},
//    new SelectListItem {Value = "24", Text = "24"},
//    new SelectListItem {Value = "25", Text = "25"},
//    new SelectListItem {Value = "26", Text = "26"},
//    new SelectListItem {Value = "27", Text = "27"},
//    new SelectListItem {Value = "28", Text = "28"},
//    new SelectListItem {Value = "29", Text = "29"},
//    new SelectListItem {Value = "30", Text = "30"},
//    new SelectListItem {Value = "31", Text = "31"},
//};

//public List<SelectListItem> Years { get; } = new List<SelectListItem>
//{
//    new SelectListItem {Value = "2000", Text = "2000"},
//    new SelectListItem {Value = "2001", Text = "2001"},
//    new SelectListItem {Value = "2002", Text = "2002"},
//    new SelectListItem {Value = "2003", Text = "2003"},
//    new SelectListItem {Value = "2004", Text = "2004"},
//    new SelectListItem {Value = "2005", Text = "2005"},
//    new SelectListItem {Value = "2006", Text = "2006"},
//    new SelectListItem {Value = "2007", Text = "2007"},
//    new SelectListItem {Value = "2008", Text = "2008"},
//    new SelectListItem {Value = "2009", Text = "2009"},
//    new SelectListItem {Value = "2010", Text = "2010"},
//    new SelectListItem {Value = "2011", Text = "2011"},
//    new SelectListItem {Value = "2012", Text = "2012"},
//    new SelectListItem {Value = "2013", Text = "2013"},
//    new SelectListItem {Value = "2014", Text = "2014"},
//    new SelectListItem {Value = "2015", Text = "2015"},
//    new SelectListItem {Value = "2016", Text = "2016"},
//    new SelectListItem {Value = "2017", Text = "2017"},
//    new SelectListItem {Value = "2018", Text = "2018"},
//    new SelectListItem {Value = "2019", Text = "2019"},
//    new SelectListItem {Value = "2020", Text = "2020"},
//    new SelectListItem {Value = "2021", Text = "2021"},
//    new SelectListItem {Value = "2022", Text = "2022"},
//    new SelectListItem {Value = "2023", Text = "2023"},
//};


