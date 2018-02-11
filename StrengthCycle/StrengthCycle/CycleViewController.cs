using System;

using UIKit;

namespace StrengthCycle
{
    /// <summary>
    /// This class is the first VC the user will see when the app is launched.
    /// It displays training cycles in the form of table view cells.
    /// Cells will display the name of the cycle,
    /// The movements involved in the cycle: Deadlift, Bent Press, Bench, Pull ups etc,
    /// The current day number of the cycle,
    /// And the date the cycle was created.
    /// </summary>
    public partial class CycleViewController : UIViewController
    {
        protected CycleViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
