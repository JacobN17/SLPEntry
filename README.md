# SLPEntry 🩺

> **Status:** 🚧 Work in Progress (Active Desktop Core Development)

> [![CI Build & Test](https://github.com/JacobN17/SLPEntry/actions/workflows/ci.yml/badge.svg)](https://github.com/JacobN17/SLPEntry/actions/workflows/ci.yml)

`SLPEntry` is an offline-first desktop application designed for Speech-Language Pathologists (SLPs). Built with **.NET MAUI Desktop**, it automates and standardizes clinical evaluation workflows by providing highly customizable diagnostic rubrics alongside robust CRUD management for clinical records.

---

## 🎯 Problem & Scope

Speech-language evaluations demand high diagnostic accuracy, yet clinicians often face fragmented tooling or rigid documentation systems. `SLPEntry` gives SLPs a localized, desktop-optimized workspace to construct custom assessment criteria and manage evaluation lifecycles seamlessly without requiring a persistent cloud connection:

* **Customizable Diagnostic Rubrics:** Flexible scoring models and evaluation frameworks tailored to specific diagnostic domains, client age groups, or clinical settings.
* **Full CRUD Clinical Management:** Create, retrieve, update, and manage rubric templates and client evaluation histories.
* **Offline-First Architecture:** Local storage ensuring full privacy, data residency, and zero-latency access during clinical sessions.
* **Desktop-First, Cross-Platform Ready:** Designed and optimized for macOS/Windows desktop environments first, with a Clean Architecture foundation structured for seamless mobile (iOS/Android) expansion in future iterations.

---

## 🏗️ Architecture & Solution Structure

The solution strictly adheres to **Clean Architecture** principles. Visual system models—including ER diagrams, sequence workflows, use cases, and class hierarchies—are maintained in the [`docs/architecture/`](./docs/architecture/) directory.
```text
SLPEntry/
├── src/
│   ├── SLPEntry.Domain/          # Core entities, rubric value objects, & domain logic
│   ├── SLPEntry.Application/     # Use cases, DTOs, & repository interfaces
│   ├── SLPEntry.Infrastructure/  # Data persistence, local SQLite/relational storage
│   └── SLPEntry.UI/              # .NET MAUI Desktop views, ViewModels, & UI components
├── tests/
│   └── SLPEntry.Tests/            # Unit test suites covering domain logic & CRUD operations
└── .github/
    └── workflows/                # Continuous Integration (CI) build and test pipelines

```

---

## 🛠️ Tech Stack & Tooling

* **Framework:** .NET MAUI Desktop (Targeting macOS & Windows)
* **Language:** C# 13 / .NET 10
* **Architecture:** Clean Architecture + MVVM Pattern
* **Testing:** xUnit / FluentAssertions
* **IDE & Tooling:** JetBrains Rider / Visual Studio, Git, GitHub Actions

---

## 🚀 Local Development Setup

### 1. Prerequisites

Ensure you have the .NET 10.0 SDK or later installed along with the MAUI workload:

```bash
dotnet workload install maui

```

### 2. Build & Run (Desktop)

Clone the repository and build the desktop solution:

```bash
git clone https://github.com/your-username/SLPEntry.git
cd SLPEntry
dotnet build SLPEntry.sln

```

### 3. Run Unit Tests

Execute the xUnit test suite across domain and application layers:

```bash
dotnet test

```

---

## 📋 Development Roadmap

- [x] Solution setup following Clean Architecture multi-project structure (.NET 10)
- [x] Continuous Integration setup via GitHub Actions (`.github/workflows`)
- [x] Domain entity design for customizable rubrics and clinical evaluation records
- [ ] Local persistence layer implementation and repository wiring
- [ ] ViewModel & Desktop UI implementation for rubric customization
- [ ] Unit test suite covering evaluation scoring and CRUD boundary validation
- [ 🚀 ] **Future Scope:** Cross-platform deployment to mobile targets (iOS & Android)

---

## ⚡ Engineering Philosophy

* **Clinician-First Utility:** Software that adapts to an SLP’s specific diagnostic rubric needs rather than forcing rigid templates.
* **Offline Resilience:** Local data ownership ensuring zero reliance on active network availability during evaluation sessions.
* **Clean Separation of Concerns:** Core domain rules isolated completely from UI components and storage implementations.

---

## 📄 License

Distributed under the MIT License. See `LICENSE` for details.

---
