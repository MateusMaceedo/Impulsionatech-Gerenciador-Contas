namespace Gerenciador.Transferencia.Application.DTos
{
    public class TransferenciaRequestDto : BaseDTOEntity<int>
    {
        public int IdContaOrigem { get; set; }
        
        public int IdContaDestino { get; set; }
        
        public decimal Valor { get; set; }
    }
}
