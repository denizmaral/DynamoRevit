﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DSRevitNodesUI.Controls
{
    /// <summary>
    /// Interaction logic for ComboControl.xaml
    /// </summary>
    public partial class ComboControl : UserControl
    {
        public ComboControl()
        {
            Resources.MergedDictionaries.Add(Dynamo.UI.SharedDictionaryManager.DynamoModernDictionary);
            InitializeComponent();
        }
    }
}
