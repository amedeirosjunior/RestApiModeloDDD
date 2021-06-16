using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produto);

        ProdutoDto MapperEntityToDto(Produto produto);
    }
}