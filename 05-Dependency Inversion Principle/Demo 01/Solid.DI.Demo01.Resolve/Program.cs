using Solid.DI.Demo01.Resolve;

IPresentation   presentation  = new ServiceManager.ServiceProvider.GetService<IPresentation>();

presentation.Button_Clicked(new Program(),EventArgs.Empty);

Console.ReadLine();