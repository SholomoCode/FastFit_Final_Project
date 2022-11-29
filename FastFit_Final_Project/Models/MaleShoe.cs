using Fast_Fit_Final_Project.Models;
using Fast_Fit_Final_Project.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace Fast_Fit_Final_Project.Model
{
    public class MaleShoe
    {
        public int MShoeSize { get; set; }
       

        public MaleShoe(int mShoeSize)
        {
            MShoeSize = mShoeSize;
        }

        /*public void ShoeSizeConverter(int mShoeSize)
        {
            if (mShoeSize == Country.Japan)
            {

            }
        }*/
    }
}
