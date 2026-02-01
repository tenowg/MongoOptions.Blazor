# MongoOptions.Blazor 🍃

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

```razor
@using MongoOptions.Blazor.Components

<ConfigSelector T="TestData"></ConfigSelector>
```

Replace `YourSettingsClass` with your POCO class decorated with `[Options]`.

## 🤝 Contributing

This project is in early alpha and welcomes community contributions! Whether it's bug fixes, new features, documentation improvements, or UI enhancements, your help is appreciated.

- Fork the repository
- Create a feature branch
- Submit a pull request

## 📄 License

Licensed under the terms in [LICENSE.txt](LICENSE.txt).

## 📞 Support

For issues or questions, please open an issue on GitHub.#