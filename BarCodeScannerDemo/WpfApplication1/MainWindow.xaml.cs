using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1 {
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();

      this.PreviewKeyDown += new KeyEventHandler(MainWindow_PreviewKeyDown);
      this.PreviewKeyUp += new KeyEventHandler(MainWindow_PreviewKeyUp);
    }

    bool mLeftCtrlDown = false;
    bool mScanShiftDown = false;
    bool mScanning = false;
    StringBuilder mScanData = new StringBuilder();
    KeyConverter mScanKeyConverter = new KeyConverter();

    void MainWindow_PreviewKeyUp(object sender, KeyEventArgs e) {
      if (e.Key == Key.LeftCtrl) {
        mLeftCtrlDown = false;
      } else if (mScanning) {
        // Handle all Keyups while scanning to preven other events from catching them
        e.Handled = true;
        if (e.Key == Key.LeftShift || e.Key == Key.RightShift) {
          // Note - We dont track shift keys separately. It is possible for us to get
          // wrong data if the user were to press 2 shift keys and then let up only 1 but we only track
          // this when scanning and a bar code scanner should be consistent.
          mScanShiftDown = false;
        }
      }
      listBox1.Items.Add("Up: " + e.Key.ToString());
    }

    void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e) {
      // Yes I know the if blocks could be conslidated, but its easier to read
      // the logic this way and expand it as necessary.
      //
      // Note: This looks for ALL Ctrl-B combos, including Ctrl-Alt-B, Ctrl-Shift-B, etc.
      // For my initial needs this is fine, but probably should be upgraded
      // to respond to only Ctrl-B
      //
      // Note also that we only look for LeftCtrl, other scanners
      // could possibly use RightCtrl but I think not. The scanner is actaully sending
      // 0x02, but WPF is likely the one interpreting it as Ctrl-B according to old keyboard semantics.
      if (e.Key == Key.LeftCtrl) {
        mLeftCtrlDown = true;
        e.Handled = true;
      } else {
        if (mScanning) {
          // Handle all Keydowns while scanning to preven other events from catching them
          e.Handled = true;
          if (e.Key == Key.LeftShift || e.Key == Key.RightShift) {
            mScanShiftDown = true;
          } else if (mLeftCtrlDown && e.Key == Key.C) {
            mScanning = false;
            listBox2.Items.Add(mScanData.ToString());
          } else {
            string xChar = mScanKeyConverter.ConvertToString(e.Key);
            if (!mScanShiftDown) {
              xChar = xChar.ToLower();
            }
            mScanData.Append(xChar);
          }
        } else {
          if (mLeftCtrlDown && e.Key == Key.B) {
            mScanning = true;
            mScanData.Clear();
            mScanShiftDown = false;
            e.Handled = true;
          }
        }
      }
      listBox1.Items.Add("Down: " + e.Key.ToString());
    }

  }
}
