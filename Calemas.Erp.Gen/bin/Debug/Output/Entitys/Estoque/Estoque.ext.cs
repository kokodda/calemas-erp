using Calemas.Erp.Domain.Validations;
using System;
using Common.Domain.Model;

namespace Calemas.Erp.Domain.Entitys
{
    public class Estoque : EstoqueBase
    {

        public Estoque()
        {

        }

        public Estoque(int estoqueid, string nome, int unidademedidaid, int categoriaestoqueid, decimal quantidademinima, decimal quantidade, bool ativo) :
            base(estoqueid, nome, unidademedidaid, categoriaestoqueid, quantidademinima, quantidade, ativo)
        {

        }

		public class EstoqueFactory
        {
            public Estoque GetDefaultInstance(dynamic data, CurrentUser user)
            {
                var construction = new Estoque(data.EstoqueId,
                                        data.Nome,
                                        data.UnidadeMedidaId,
                                        data.CategoriaEstoqueId,
                                        data.QuantidadeMinima,
                                        data.Quantidade,
                                        data.Ativo);

                construction.SetarDescricao(data.Descricao);
                construction.SetarModelo(data.Modelo);
                construction.SetarFabricante(data.Fabricante);
                construction.SetarReferencia(data.Referencia);
                construction.SetarObservacao(data.Observacao);
                construction.SetarValorVenda(data.ValorVenda);
                construction.SetarValorCompra(data.ValorCompra);


				return construction;
            }

        }

        public bool IsValid()
        {
            base._validationResult = new EstoqueEstaConsistenteValidation().Validate(this);
            return base._validationResult.IsValid;

        }
        
    }
}
