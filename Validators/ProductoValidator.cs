using ApiColaborativa.Dtos;

namespace ApiColaborativa.Validators;

public static class ProductoValidator
{
    public static bool EsValido(ProductoDto producto)
    {
        return producto.Id > 0
            && !string.IsNullOrWhiteSpace(producto.Nombre)
            && producto.Precio >= 0;
    }
}
