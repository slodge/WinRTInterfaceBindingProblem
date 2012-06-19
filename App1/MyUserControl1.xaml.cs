using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace App1
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
        }

        public SimpleRelayCommand DirectCommand
        {
            get { return (SimpleRelayCommand)GetValue(DirectCommandProperty); }
            set { SetValue(DirectCommandProperty, value); }
        }

        public static readonly DependencyProperty DirectCommandProperty =
            DependencyProperty.Register("DirectCommand", typeof(SimpleRelayCommand), typeof(MyUserControl1), new PropertyMetadata(null));

        public BaseSimpleRelayCommand IndirectCommand
        {
            get { return (BaseSimpleRelayCommand)GetValue(IndirectCommandProperty); }
            set { SetValue(IndirectCommandProperty, value); }
        }

        public static readonly DependencyProperty IndirectCommandProperty =
            DependencyProperty.Register("IndirectCommand", typeof(BaseSimpleRelayCommand), typeof(MyUserControl1), new PropertyMetadata(null));

        public ICommand InterfaceCommand
        {
            get { return (ICommand)GetValue(InterfaceCommandProperty); }
            set { SetValue(InterfaceCommandProperty, value); }
        }

        public static readonly DependencyProperty InterfaceCommandProperty =
            DependencyProperty.Register("InterfaceCommand", typeof(ICommand), typeof(MyUserControl1), new PropertyMetadata(null));

        public IIntermediateCommand InterfaceICommand
        {
            get { return (IIntermediateCommand)GetValue(InterfaceICommandProperty); }
            set { SetValue(InterfaceICommandProperty, value); }
        }

        public static readonly DependencyProperty InterfaceICommandProperty =
            DependencyProperty.Register("InterfaceICommand", typeof(IIntermediateCommand), typeof(MyUserControl1), new PropertyMetadata(null));

        private void Button1_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (DirectCommand != null)
                DirectCommand.Execute(null);
        }

        private void Button4_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (IndirectCommand != null)
                IndirectCommand.Execute(null);
        }

        private void Button2_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (InterfaceCommand != null)
                InterfaceCommand.Execute(null);
        }

        private void Button3_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (InterfaceICommand != null)
                InterfaceICommand.Execute(null);
        }

    }
}
