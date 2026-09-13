# [Project Title]

> [Short one-line description of the project, e.g. "A RAG-based question answering system using local LLMs."]

This project was developed as part of a thesis work at [University Name], [Department Name], Academic Year [YYYY/YYYY].

---

## Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
  - [1. Download the Source Code](#1-download-the-source-code)
  - [2. Set Up LM Studio](#2-set-up-lm-studio)
  - [3. Set Up the Python Virtual Environment](#3-set-up-the-python-virtual-environment)
- [Running the Application](#running-the-application)
  - [1. Start LM Studio](#1-start-lm-studio)
  - [2. Start the Retrieval API](#2-start-the-retrieval-api)
  - [3. Start the Back-end](#3-start-the-back-end)
  - [4. Start the Front-end](#4-start-the-front-end)
- [Authors](#authors)
- [Supervisor](#supervisor)
- [License](#license)

---

## Overview

[Provide a concise description of the project: what problem it solves, the approach used, and the main technologies involved. This section should be self-contained and understandable without prior knowledge of the codebase.]

---

## Architecture

[Briefly describe the system architecture. Mention the main components and how they interact: e.g. front-end, back-end API, retrieval API, LLM inference server. A diagram or reference to one is recommended.]

---

## Prerequisites

Before proceeding, ensure the following software is installed on your system:

- [Git](https://git-scm.com/)
- [Python 3.10+](https://www.python.org/downloads/)
- [Node.js 18+ and npm](https://nodejs.org/)
- [LM Studio](https://lmstudio.ai/download)
- [JetBrains Rider](https://www.jetbrains.com/rider/) *(required only to run the back-end via IDE; see Section 3.1)*
- [.NET SDK [version]](https://dotnet.microsoft.com/download) *(required to run the back-end from the terminal; see Section 3.2)*

---

## Installation

### 1. Download the Source Code

Clone the repository using Git:

```bash
# HTTPS
git clone https://gitlab.com/i3lab/tesinicologiallongo.git

# SSH
git clone git@gitlab.com:i3lab/tesinicologiallongo.git
```

Then navigate into the project directory:

```bash
cd Code
```

### 2. Set Up LM Studio

1. Download and install LM Studio from: https://lmstudio.ai/download

2. Open LM Studio.

3. Navigate to the **Model Search** panel (`Ctrl + Shift + M`).

4. Download the following models:
   - **LLM:** `llama-3.1-8b-instruct` by *unsloth*, quantization `Q5_K_XL`
   - **Embedding:** `text-embedding-gemma-300m` by *unsloth*, quantization `Q8_0`

### 3. Set Up the Python Virtual Environment

1. Open a terminal and navigate to the retrieval API folder:

   ```bash
   cd Code/retrieval_api
   ```

2. Create the virtual environment:

   ```bash
   python -m venv venv
   ```

3. Activate the virtual environment:

   **Windows (PowerShell):**
   ```powershell
   .\venv\Scripts\Activate.ps1
   ```
   > If PowerShell blocks script execution, run the following command once and then retry:
   > ```powershell
   > Set-ExecutionPolicy -Scope CurrentUser RemoteSigned
   > ```

   **macOS / Linux:**
   ```bash
   source venv/bin/activate
   ```

4. Upgrade pip and install the required dependencies:

   ```bash
   python -m pip install --upgrade pip
   python -m pip install -r requirements.txt
   ```

   > Warning: the current `requirements.txt` is a snapshot of the working environment already present in this repository. It reflects the packages currently installed in the local `venv`, but it may not be a conflict-free, fresh-install setup for every machine.
   > If you want to reproduce the exact environment used here, prefer the existing local `venv` folder in the project.

   Once the environment is active, you will see `(venv)` prepended to your terminal prompt. To deactivate it at any time, run:

   ```bash
   deactivate
   ```

---

## Running the Application

All four components must be started in the order listed below.

### 1. Start LM Studio

1. Open LM Studio.
2. Navigate to the **Developer** panel (`Ctrl + 2`).
3. On the Server Setting, set the Server Port to 1234
3. Start the local inference server by clicking the **Start Server** button, or using the shortcut `Ctrl + R`.

### 2. Start the Architecture

1. Open a terminal and navigate to the retrieval API folder:

   ```bash
   cd Code/retrieval_api
   ```

2. Activate the virtual environment (see [Installation → Step 3](#3-set-up-the-python-virtual-environment) if not already done).

3. Start the server:

   ```bash
   python run.py
   ```

### 3. Start the Back-end

#### Option A — From JetBrains Rider

1. Open the folder `Code/backend_api/ThesisBackendAPI` in JetBrains Rider.
2. Run the entry point: `Code/backend_api/ThesisBackendAPI/ThesisBackendAPI/Program.cs`

#### Option B — From the Terminal

1. Navigate to the back-end project folder:

   ```bash
   cd Code/backend_api/ThesisBackendAPI/ThesisBackendAPI
   ```

2. Build and run the application:

   ```bash
   dotnet run
   ```

   > Ensure the [.NET SDK [version]](https://dotnet.microsoft.com/download) is installed before proceeding.

### 4. Start the Front-end

1. Open a terminal and navigate to the front-end folder:

   ```bash
   cd Code/frontend/my-app
   ```

2. Start the development server:

   ```bash
   npm run dev
   ```

3. Open the URL printed in the terminal (typically `http://localhost:3000`) in your browser of choice.

---

## Authors

- **[Full Name]** — [Student ID / Role] — [email@university.edu]

## Supervisor

- **[Prof./Dr. Full Name]** — [Department] — [University Name]

---

## License

[Specify the license, e.g.: This project is licensed for academic use only. All rights reserved. / MIT License / etc.]
