﻿using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{//esta clase se creo solo para pruebas
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id=1, Nombre="Vista a lapiscina", Ocupantes=3, MetrosCuadrados=50},
            new VillaDto{Id=2, Nombre="vista al mar", Ocupantes=4, MetrosCuadrados=80}
        };
    }
}
