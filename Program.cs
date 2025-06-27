using System;

namespace memento
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Originator originator = new Originator();
      originator.SetState("Состояние 1");
      Console.WriteLine("Текущее состояние: " + originator.GetState());

      Memento memento = originator.SaveState();

      originator.SetState("Состояние 2");
      Console.WriteLine("Текущее состояние: " + originator.GetState());

      originator.RestoreState(memento);
      Console.WriteLine("Восстановленное состояние: " + originator.GetState());
    }
  }

  public class Memento
  {
    private string state;

    public Memento(string state)
    {
      this.state = state;
    }

    public string GetState()
    {
      return state;
    }
  }

  public class Originator
  {
    private string state;

    public void SetState(string state)
    {
      this.state = state;
    }

    public string GetState()
    {
      return state;
    }

    public Memento SaveState()
    {
      return new Memento(state);
    }
    public void RestoreState(Memento memento)
    {
      state = memento.GetState();
    }
  }
}
