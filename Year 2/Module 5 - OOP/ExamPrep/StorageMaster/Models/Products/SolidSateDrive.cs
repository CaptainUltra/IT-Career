namespace StorageMaster.Models.Products
{
    public class SolidSateDrive : Product
    {
        private const double SolidSateDriveWeight = 0.2;
        public SolidSateDrive(double price) 
            : base(price, SolidSateDriveWeight) { }
    }
}