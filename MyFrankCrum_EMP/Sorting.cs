﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyFrankCrum_EMP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Sorting recording.
    /// </summary>
    [TestModule("bf8fc426-e5e8-44cd-9fae-692b0e1c040f", ModuleType.Recording, 1)]
    public partial class Sorting : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Sorting instance = new Sorting();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Sorting()
        {
            Sortingvalue = "Last Name: A-Z";
            As_new_variable___ = "";
            FlexRowValue = "XYZ";
            EmployeeNumber = "AWS";
            JobTitle = "ASD";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Sorting Instance
        {
            get { return instance; }
        }

#region Variables

        string _As_new_variable___;

        /// <summary>
        /// Gets or sets the value of variable As_new_variable___.
        /// </summary>
        [TestVariable("f5155496-9058-41c2-ae7b-dd0ad5e3bc08")]
        public string As_new_variable___
        {
            get { return _As_new_variable___; }
            set { _As_new_variable___ = value; }
        }

        string _FlexRowValue;

        /// <summary>
        /// Gets or sets the value of variable FlexRowValue.
        /// </summary>
        [TestVariable("1676eaeb-a1fc-4763-9ef9-98afdbb89063")]
        public string FlexRowValue
        {
            get { return _FlexRowValue; }
            set { _FlexRowValue = value; }
        }

        string _EmployeeNumber;

        /// <summary>
        /// Gets or sets the value of variable EmployeeNumber.
        /// </summary>
        [TestVariable("02fcbffb-c191-4245-b0c1-88c5f96a4bf2")]
        public string EmployeeNumber
        {
            get { return _EmployeeNumber; }
            set { _EmployeeNumber = value; }
        }

        string _JobTitle;

        /// <summary>
        /// Gets or sets the value of variable JobTitle.
        /// </summary>
        [TestVariable("92f6cb93-ecb6-4003-9bb8-964882b0df51")]
        public string JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Sortingvalue.
        /// </summary>
        [TestVariable("f17c01d4-2115-4a8a-8535-c75aeffd4d53")]
        public string Sortingvalue
        {
            get { return repo.Sortingvalue; }
            set { repo.Sortingvalue = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.FaCaretDownFas' at Center.", repo.ApplicationUnderTest.SomeDivTag.FaCaretDownFasInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SomeDivTag.FaCaretDownFas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.Sortingvalue' at Center.", repo.ApplicationUnderTest.SomeDivTag.SortingvalueInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.SomeDivTag.Sortingvalue.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.FlexRow2' at Center.", repo.ApplicationUnderTest.SomeDivTag.FlexRow2Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SomeDivTag.FlexRow2.Click();
            Delay.Milliseconds(0);
            
            Get_value_FlexRowName(repo.ApplicationUnderTest.SomeDivTag.FlexRowNameInfo, Sortingvalue);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.FlexRowName' at Center.", repo.ApplicationUnderTest.SomeDivTag.FlexRowNameInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.SomeDivTag.FlexRowName.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "User", "", new RecordItemIndex(5));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.EmployeeNumber' at Center.", repo.ApplicationUnderTest.SomeDivTag.EmployeeNumberInfo, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.SomeDivTag.EmployeeNumber.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.SomeDivTag.EmployeeNumber' and assigning its value to variable 'EmployeeNumber'.", repo.ApplicationUnderTest.SomeDivTag.EmployeeNumberInfo, new RecordItemIndex(7));
            //EmployeeNumber = repo.ApplicationUnderTest.SomeDivTag.EmployeeNumber.Element.GetAttributeValueText("InnerText");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.JobTitle' at Center.", repo.ApplicationUnderTest.SomeDivTag.JobTitleInfo, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.SomeDivTag.JobTitle.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.SomeDivTag.JobTitle' and assigning its value to variable 'JobTitle'.", repo.ApplicationUnderTest.SomeDivTag.JobTitleInfo, new RecordItemIndex(9));
            //JobTitle = repo.ApplicationUnderTest.SomeDivTag.JobTitle.Element.GetAttributeValueText("InnerText");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}