using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

public class MainWindowViewModel : BindableBase
{
    public DelegateCommand RunCommand { get; set; }
    public DelegateCommand StopCommand { get; set; }
    public DelegateCommand jumpCommand { get; set; }
    public DelegateCommand OutputCommand { get; set; }

    public DelegateCommand DogCommand {  get; set; }
    public DelegateCommand PantherCommand {  get; set; }
    public DelegateCommand TurtleCommand {  get; set; }

    private Animal _animal;
    private string _data = "Выберите животное";
    
    public MainWindowViewModel()
    {
        DogCommand = new DelegateCommand(Dog);
        PantherCommand = new DelegateCommand(Panther);
        TurtleCommand = new DelegateCommand(Turtle);
        RunCommand = new DelegateCommand(Run);
        StopCommand = new DelegateCommand(Stop);
        jumpCommand = new DelegateCommand(jump);
        Data = _data;
    }

    private void Dog()
    {
        _animal = new Dog();
        Data = $"Собака, максимальная скорость = {_animal.GetMaxSpeed()}";

        //MessageBox.Show($"Max speed = {_animal.GetMaxSpeed()}");
    }

    private void Panther()
    {
        _animal = new Panther();
        Data = $"Пантера, максимальная скорость = {_animal.GetMaxSpeed()}";
        //MessageBox.Show($"Max speed = {_animal.GetMaxSpeed()}");
    }

    private void Turtle()
    {
        _animal = new Turtle();
        Data = $"Черепаха, максимальная скорость = {_animal.GetMaxSpeed()}";
        //MessageBox.Show($"Max speed = {_animal.GetMaxSpeed()}");
    }

    private void Run()
    {
        if(_animal != null)
        {
            Data = _animal.Go();
        }
        else
        {
            Data = "Выберите животное";
        }
    }

    private void Stop()
    {
        if (_animal != null)
        {
            Data = _animal.Stay();
        }
        else
        {
            Data = "Выберите животное";
        }
    }

    private void jump()
    {
        if (_animal != null)
        {
            Data = _animal.jump();
        }
        else
        {
            Data = "Выберите животное";
        }
    }

    public string Data
    {
        get => _data;
        set => SetProperty(ref _data, value);
    }
}