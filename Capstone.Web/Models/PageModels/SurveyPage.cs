
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models.PageModels
{
  public class SurveyPage
  {

    public List<Park> Parks { get; set; } = new List<Park>();

    public List<SurveyPost> Surveys { get; set; } = new List<SurveyPost>();

    public Dictionary<string, string> States
    {
      get
      {
        return new Dictionary<string, string>() {
          {"Alabama","AL"                         },
          {"Alaska","AK"                          },
          {"Arizona","AZ"                         },
          {"Arkansas","AR"                        },
          {"California","CA"                      },
          {"Colorado","CO"                        },
          {"Connecticut","CT"                     },
          {"Delaware","DE"                        },
          {"Florida","FL"                         },
          {"Georgia","GA"                         },
          {"Hawaii","HI"                          },
          {"Idaho","ID"                           },
          {"Illinois","IL"                        },
          {"Indiana","IN"                         },
          {"Iowa","IA"                            },
          {"Kansas","KS"                          },
          {"Kentucky","KY"                        },
          {"Louisiana","LA"                       },
          {"Maine","ME"                           },
          {"Montana","MT"                         },
          {"Nebraska","NE"                        },
          {"Nevada","NV"                          },
          {"New Hampshire","NH"                   },
          {"New Jersey","NJ"                      },
          {"New Mexico","NM"                      },
          {"New York","NY"                        },
          {"North Carolina","NC"                  },
          {"North Dakota","ND"                    },
          {"Ohio","OH"                            },
          {"Oklahoma","OK"                        },
          {"Oregon","OR"                          },
          {"Maryland","MD"                        },
          {"Massachusetts","MA"                   },
          {"Michigan","MI"                        },
          {"Minnesota","MN"                       },
          {"Mississippi","MS"                     },
          {"Missouri","MO"                        },
          {"Pennsylvania","PA"                    },
          {"Rhode Island","RI"                    },
          {"South Carolina","SC"                  },
          {"South Dakota","SD"                    },
          {"Tennessee","TN"                       },
          {"Texas","TX"                           },
          {"Utah","UT"                            },
          {"Vermont","VT"                         },
          {"Virginia","VA"                        },
          {"Washington","WA"                      },
          {"West Virginia","WV"                   },
          {"Wyoming","WY"                         },
          {"Wisconsin","WI"                       }
                  };
      }
    }
  }
}



