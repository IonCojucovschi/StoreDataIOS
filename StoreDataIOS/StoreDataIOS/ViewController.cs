using System;
using System.IO;
using UIKit;

namespace StoreDataIOS
{
    public partial class ViewController : UIViewController
    {
        void SubmitButton_TouchUpInside(object sender, EventArgs e)
        {
            // get the data from the text box
            string name = nameBox.Text;
            string phone = phoneBox.Text;
            string line = string.Format("{0},{1}",name,phone);

            //store information
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(documents, "MyContacts.txt");
            var text = File.ReadAllText(filename);

            File.WriteAllText(filename,text+","+line);



            var alert = UIAlertController.Create("Confirm","Contact Added",UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("OK",UIAlertActionStyle.Default,null));

            //CLEAR OUT BOXES
            nameBox.Text = "";
            phoneBox.Text = "";

        
        }


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            submitButton.TouchUpInside -= SubmitButton_TouchUpInside;
            submitButton.TouchUpInside+=SubmitButton_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }



    }
}
