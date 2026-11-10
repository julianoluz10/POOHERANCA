
namespace Heranca
{
    public interface IPagamento//Uma Interface define um contrato que
    //  estabelce quais metodos e propriedades ou outros membros uma classe deve disponibilizar
    
    {
        void Pagar(decimal valor);
        //void pagar (decimal valor) interface pode conter diversos métodos
        
    }
}