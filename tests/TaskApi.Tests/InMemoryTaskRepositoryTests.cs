using TaskApi.Repositories;
using TaskApi.Models;
using FluentAssertions;

namespace TaskApi.Tests.Repositories;

public class InMemoryTaskRepositoryTests {

    private readonly InMemoryTaskRepository _repo;

    public InMemoryTaskRepositoryTests(){
        _repo = new();
    }

    // [Fact]
    // public void Add_TareaValida_AsignaIdYRetornaTarea(){

    //     //Arrange        
    //     var tarea = new TaskItem {
    //         Title = "Comprar Guitarra",
    //         Description= "Comprar Guitarra para ser Feliz"
    //     };

    //     //Act
    //     var resultado = _repo.Add(tarea);
    //     //Arrange
    //     resultado.Id.Should().BeGreaterThan(0);
    //     resultado.Title.Should().Be("Comprar Guitarra");
    // }

    // [Fact]
    // public void Aigna_DosTareas_AsignaIdSecuenciales(){

    //     //Arrange        
    //     var tarea1 = new TaskItem {
    //         Title = "Comprar Guitarra",
    //         Description= "Comprar Guitarra para ser Feliz"
    //     };
    //     var tarea2 = new TaskItem {
    //         Title = "Comprar Laptop",
    //         Description= "Comprar Laptop"
    //     };

    //     //Act
    //     var r1 = _repo.Add(tarea1);
    //     var r2 = _repo.Add(tarea2);

    //     //Arrange
    //     r2.Id.Should().Be(r1.Id + 1);
    //     //resultado.Title.Should().Be("Comprar Guitarra");
    // }

    // //GetAll
    // [Fact]
    // public void GetAll_RepositorioVacio_RetornaCollecionVacia(){
    //     //Arrange

    //     //Act
    //     var resultado = _repo.GetAll();

    //     //Assert
    //     resultado.Should().BeEmpty();
    // }

    // [Fact]
    // public void GetAll_ConDosTareas_RetornaDosTareas(){
    //     //Arrange        
    //     var tarea1 = new TaskItem {
    //         Title = "Comprar Guitarra",
    //         Description= "Comprar Guitarra para ser Feliz"
    //     };
    //     var tarea2 = new TaskItem {
    //         Title = "Comprar Laptop",
    //         Description= "Comprar Laptop"
    //     };
    //     var r1 = _repo.Add(tarea1);
    //     var r2 = _repo.Add(tarea2);

    //     //Act
    //    var resultado = _repo.GetAll();

    //    //Assert
    //    resultado.Should().HaveCount(2);
    // }

    // //GetById
    // [Fact]
    // public void GetById_TareaExiste_RetornaTarea()
    // {
    //     //Arrange
    //     var tarea1 = new TaskItem
    //     {
    //         Title = "Comprar Guitarra",
    //         Description = "Comprar Guitarra para ser Feliz"
    //     };

    //     var tareaAgregada = _repo.Add(tarea1);

    //     //Act
    //     var resultado = _repo.GetById(tareaAgregada.Id);

    //     //Assert
    //     resultado.Should().NotBeNull(); //resultado.Should().BeNull();
    //     resultado!.Title.Should().Be("Comprar Guitarra");
    // }

    // [Fact]
    // public void GetId_IdNoExiste_RetornaNull(){
    //     //Arrange

    //     //Act
    //     var resultado = _repo.GetById(1000);

    //     //Assert
    //     resultado.Should().BeNull();
    // }

    // [Fact]
    // public void Update_TareaExiste_ActualizaPropiedades(){
    //     //Arrange
    //     var tareaOriginal = _repo.Add(new TaskItem{
    //         Title = "Tarea 1",
    //         Description = "Tarea 1"
    //     });

    //     var cambiosTarea = new TaskItem{
    //         Title = "Actualizada",
    //         Description = "Tarea 1 actualizada"
    //     };

    //     //Act
    //     var resultado = _repo.Update(tareaOriginal.Id,cambiosTarea);

    //     //Assert
    //     resultado.Should().NotBeNull();
    //     resultado!.Title.Should().Be("Actualizada");
    // }

    //agregar updateidnoexiste
    // public void Update_IdNoExiste_RetornaNull(){
    //     //Act
    //     var resultado = _repo.Update(1000, new TaskItem{Title="xxx"});

    //     //Assert
    //     resultado.Should().BeNull();
    // }


    // [Fact]
    // public void Delete_TareaExiste_RetornaTrue(){
    //     var tareaAgregada = _repo.Add(new TaskItem{Title="Tarea a eliminar"});

    //     var resultado = _repo.Delete(tareaAgregada.Id);

    //     resultado.Should().BeTrue();
    //     _repo.GetById(tareaAgregada.Id).Should().BeNull();
    // }

    // [Fact]
    // public void Delete_IdNoExiste_RetornoFalse(){
    //     //Act
    //     var resultado = _repo.Delete(1000);

    //     //Assert
    //     resultado.Should().BeFalse();
    // }
 

 

 

}