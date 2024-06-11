namespace Projeto_Web_Lh_Pets_versão_1
{
    class Clientes
    {
        public string? Cpf_cnpj { get; set; }
        public required string Nome { get; set; }
        public required string endereco { get; set; }
        public required string Rg_ie { get; set; }
        public required string Tipo { get; set; }
        public float Valor { get; set; }
        public float Valor_imposto { get; set; }
        public float Total { get; set; }
    }
}