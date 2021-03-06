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
    ///The Resources_FrankCrum_Team recording.
    /// </summary>
    [TestModule("ea9ad2b9-24ce-435c-8f9f-c85e0831cf56", ModuleType.Recording, 1)]
    public partial class Resources_FrankCrum_Team : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Resources_FrankCrum_Team instance = new Resources_FrankCrum_Team();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Resources_FrankCrum_Team()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Resources_FrankCrum_Team Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FrankCrumTeam' at 52;7.", repo.ApplicationUnderTest.FrankCrumTeamInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FrankCrumTeam.Click("52;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.Save' at 17;15.", repo.ApplicationUnderTest.BalanceViewContainer.SaveInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.BalanceViewContainer.Save.Click("17;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After click Save button", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(3));
            
            // Email
            Report.Log(ReportLevel.Info, "Section", "Email", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.MailtoNwtestAtfrankcrumCom' at 16;31.", repo.ApplicationUnderTest.BalanceViewContainer.MailtoNwtestAtfrankcrumComInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.BalanceViewContainer.MailtoNwtestAtfrankcrumCom.Click("16;31");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            // Favorite
            Report.Log(ReportLevel.Info, "Section", "Favorite", new RecordItemIndex(7));
            
            Report.Screenshot(ReportLevel.Info, "User", "Before Add Favorite screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.Favorite' at 0;14.", repo.ApplicationUnderTest.BalanceViewContainer.FavoriteInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.BalanceViewContainer.Favorite.Click("0;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ReactTabsTabList1.FavoriteContacts' at 44;17.", repo.ApplicationUnderTest.ReactTabsTabList1.FavoriteContactsInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.ReactTabsTabList1.FavoriteContacts.Click("44;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(12));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After Add Favorite screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(13));
            
            // Call
            Report.Log(ReportLevel.Info, "Section", "Call", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BalanceViewContainer.Callbutton' at 15;26.", repo.ApplicationUnderTest.BalanceViewContainer.CallbuttonInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.BalanceViewContainer.Callbutton.Click("15;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(16));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "After click call btn  screenshot", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MakeACallFrom.Close' at 14;12.", repo.MakeACallFrom.CloseInfo, new RecordItemIndex(18));
            repo.MakeACallFrom.Close.Click("14;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
