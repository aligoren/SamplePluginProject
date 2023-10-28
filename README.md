# SamplePluginProject

In this project, we see how a simple plugin architecture can be implemented in the most basic ways.

WordPress's event structure is much better than this. However, this just shows how the structure can work. By looking at the `_plugin.Hooks.DoAction` code inside PostService, you can understand how the structure operates;

Plugins are automatically loaded with `GetEntryAssembly` when the project is run.
