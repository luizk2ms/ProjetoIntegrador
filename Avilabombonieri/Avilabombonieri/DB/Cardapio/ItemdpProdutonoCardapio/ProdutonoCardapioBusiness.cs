//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lanchonha.Banco.BD.Cardapio.ItemdpProdutonoCardapio
//{
//    class ProdutonoCardapioBusiness
//    {
//        public int Salvar (List<ItemProdutoCardapioGrid> dadosdatela)
//        {
//            int pk=0;
//            ProdutonoCardapioDTO dto = new ProdutonoCardapioDTO();
//            ProdutonoCardapioDataBase db = new ProdutonoCardapioDataBase();

//            foreach (ItemProdutoCardapioGrid item in dadosdatela)
//            {
//                dto.FkidCardapio = item.FkidCardapio;
//                dto.FKidEstoque = item.FKidEstoque;
//                pk= db.Salvar(dto);
//            }
//            return pk;
//        }

//        public void Remover (int ID)
//        {
//            ProdutonoCardapioDataBase db = new ProdutonoCardapioDataBase();
//            db.Remover(ID);
//        }
//    }
//}
