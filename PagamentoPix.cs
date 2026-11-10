namespace Heranca
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
            //throw new NotImplementedException();
            //?Classe nativa do c# 
            //?em qunato a definiç~çao do metodo não
            //?  e criado pelo desenvolvedor
           
            Console.WriteLine($"Pagamento via Pix: {valor:C}");
        }

        
    }
}