# MongoOptions.Blazor 🍃

Due to Code Generation this library is only an example of use. You need to download the project code and add it to a project to use as is.
A Blazor component library for managing MongoDB-based configurations using MongoOptions. Provides UI components for CRUD operations on configuration settings stored in MongoDB.

## 🚀 Features

* **Blazor Components**: Ready-to-use UI components for viewing and editing configuration options.
* **Integration with MongoOptions**: Seamlessly works with the core library for resilient, cached MongoDB configurations.
* **Data Validation**: Inherits validation from Data Annotations in your POCO classes.
* **Responsive Design**: Built with Blazor for modern web applications.

## 📦 Installation

```bash
dotnet add package Tenowg.MongoOptions.Blazor
```

Ensure you have MongoOptions installed as a dependency.

## 🛠️ Quick Start

### 1. Set up MongoOptions

First, configure MongoOptions in your Blazor app as described in the [MongoOptions README](https://github.com/tenowg/MongoOptions).

### 2. Add Components to Your App

Import the library and use the provided components in your Razor pages.

>> Before using this library and dashboard you need to understand this is very early stages
>> It does work, but man is it ugly I will be working on styling the dashboard better in the
>> near future (or if someone else wants to take a shot, be my guest, just leave me
>> an issue so I know you are working on it) Thanks

```razor
@using MongoOptions.Blazor.Components

<ConfigSelector T="TestData"></ConfigSelector>
```

or if you wish to use the class selector which handles all your registered classes and creates a full dashboard
this is really all you need to have a full dashboard to edit your configuration files in MongoDB

```razor
@using MongoOptions.Blazor.Components

<ClassSelector/>
```

Replace `YourSettingsClass` with your POCO class decorated with `[Options]`.

## RoadMap
- Work on Css styling
- Due some issues with typing and components there are some limitations on what types that are allowed in your config classes, unfortunatly right now you just have to live and learn, as I get a strong grasp on what can't be use I will document it.

## 🤝 Contributing

This project is in early alpha and welcomes community contributions! Whether it's bug fixes, new features, documentation improvements, or UI enhancements, your help is appreciated.

- Fork the repository
- Create a feature branch
- Submit a pull request

## 📄 License

Licensed under the terms in [LICENSE.txt](LICENSE.txt).

## 📞 Support

For issues or questions, please open an issue on GitHub.#