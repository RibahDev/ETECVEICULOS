using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Data
{
    public class AppDbSeed
    {
        public AppDbSeed(ModelBuilder modelBuilder)
        {
            #region TipoVeiculo
            List<TipoVeiculo> tipoVeiculos = [
                new(){
                    Id = 1,
                    Name = "Moto"
                },
                new(){
                    Id = 2,
                    Name = "Carro"
                },
                new(){
                    Id = 3,
                    Name = "Caminhão"
                },
            ];
            modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
            #endregion

            #region Marca
            List<Marca> marcas  = [
                new(){
                    Id = 1,
                    Nome = "Volkswagen"
                },
                new (){
                    Id = 2,
                    Nome = "Chevrolet"
                },
                new (){
                    Id = 3,
                    Nome = "Honda"
                }
            ];
            #endregion
            modelBuilder.Entity<Marca>().HasData(marcas);

            #region Modelo
            List<Modelo> modelos = new() {
                new() {
                    Id = 1,
                    Nome = "Gol",
                    MarcaId = 1
                },
                new() {
                    Id = 2,
                    Nome = "T-Cross",
                    MarcaId = 1
                },
                new() {
                    Id = 3,
                    Nome = "Onix",
                    MarcaId = 2
                },
                new() {
                    Id = 4,
                    Nome = "Cruze",
                    MarcaId = 2
                },
                new() {
                    Id = 5,
                    Nome = "Civic",
                    MarcaId = 3
                },
                new() {
                    Id = 6,
                    Nome = "Fit LX",
                    MarcaId = 3
                },
            };
            modelBuilder.Entity<Modelo>().HasData(modelos);
            #endregion
        }
    }
}