using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;
using GwPlatformDotNet.Lib.Enums;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class FuzzyLogic
    {
        public static List<FuzzyLogic> AllFuzzyLogics { get; private set; }

        public static List<String> AllFuzzyLogicValues { get; private set; }

        public static FuzzyLogic TRUE { get; private set; }

        public static FuzzyLogic MAYBE { get; private set; }

        public static FuzzyLogic FALSE { get; private set; }

        private static  void PopulateAllFuzzyLogics() {
            FuzzyLogic.AllFuzzyLogics = new List<FuzzyLogic>();
            FuzzyLogic.AllFuzzyLogicValues = new List<String>();

            FuzzyLogic.TRUE= new FuzzyLogic() {
                Value = "True",
            };

            FuzzyLogic.AllFuzzyLogics.Add(FuzzyLogic.TRUE);
            FuzzyLogic.AllFuzzyLogicValues.Add(FuzzyLogic.TRUE.Value);

            FuzzyLogic.MAYBE = new FuzzyLogic() {
                Value = "Maybe",
            };

            FuzzyLogic.AllFuzzyLogics.Add(FuzzyLogic.MAYBE);
            FuzzyLogic.AllFuzzyLogicValues.Add(FuzzyLogic.MAYBE.Value);
            
            FuzzyLogic.FALSE= new FuzzyLogic() {
                Value = "False",
            };

            FuzzyLogic.AllFuzzyLogics.Add(FuzzyLogic.FALSE);
            FuzzyLogic.AllFuzzyLogicValues.Add(FuzzyLogic.FALSE.Value);

        }
    }
}