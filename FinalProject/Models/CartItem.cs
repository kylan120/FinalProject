using System.Diagnostics.Eventing.Reader;

namespace FinalProject.Models
{
    public class CartItem
    {
        public BoardGame BoardGame { get; set; }

        public int Quantity {  get; set; }

        public double Subtotal => BoardGame.Price * Quantity;
    }
}
