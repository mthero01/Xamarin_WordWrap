/** [!]. ABOUT
 * "class Hierarchy"
 * by Matthew testc. Theroux
 * for Baker Collage Online CS4010
 * Module 08 Assignment 01 (#15)
 * under Joan Zito
 * (c) 2018 
 * --
 **/
/// [I]. HEAD
///  A] IMPORTS
using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Core;
using Xamarin.Xaml;
//<...>

///
namespace ClassHierarcy {
    public partial class ClassHierarcyPage : ContentPage
    {
    /// [II]. BODY
        InitializeComponent(); // from XAML

        List<TypeInformation> listOfClasses = new List<TypeInformation>();

        /// Fetch all types in Xamarin.Forms.Core assembly.
        //<!>
        //GetPublicTypes(typeof(View).GetTypeInfo().Assembly, classList);



    /// [III]. FOOT
    }// /cla 'ClassHierarcyPage'
}// /ns 'ClassHierarcy'
/// [EoF].