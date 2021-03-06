///////////////////////////////////////////////////////////////////////////////
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
    ///The Employee_Taxes_Add_Location recording.
    /// </summary>
    [TestModule("d9c7fa67-4bbd-4286-8595-eafdd405e752", ModuleType.Recording, 1)]
    public partial class Employee_Taxes_Add_Location : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employee_Taxes_Add_Location instance = new Employee_Taxes_Add_Location();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employee_Taxes_Add_Location()
        {
            LocationName = "006645";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employee_Taxes_Add_Location Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RepoURL.
        /// </summary>
        [TestVariable("c75816bd-3150-4b49-aa6d-f8479454f515")]
        public string RepoURL
        {
            get { return repo.RepoURL; }
            set { repo.RepoURL = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable LocationName.
        /// </summary>
        [TestVariable("935da909-cd95-4e30-a524-a53e8ec1b639")]
        public string LocationName
        {
            get { return repo.LocationName; }
            set { repo.LocationName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Taxes' at Center.", repo.ApplicationUnderTest.TaxesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Taxes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddNewLocation' at Center.", repo.ApplicationUnderTest.AddNewLocationInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AddNewLocation.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddLocationDropClick' at Center.", repo.ApplicationUnderTest.AddLocationDropClickInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AddLocationDropClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LocationName' with focus on 'ApplicationUnderTest.AddLocationDropClick'.", repo.ApplicationUnderTest.AddLocationDropClickInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.AddLocationDropClick.PressKeys(LocationName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{return}' with focus on 'ApplicationUnderTest.AddLocationDropClick'.", repo.ApplicationUnderTest.AddLocationDropClickInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.AddLocationDropClick.PressKeys("{return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IsPrimary' at Center.", repo.ApplicationUnderTest.IsPrimaryInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.IsPrimary.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddLocation' at Center.", repo.ApplicationUnderTest.AddLocationInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AddLocation.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
