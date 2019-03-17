# mvtemplate
Template for creating MVExtension projects for (MIIS/ILM)/FIM/MIM directly within Visual Studio

## Overview
This library is used to create a new project type in Visual Studio that enables you to create MVExtension projects directly
rather than needing to use the FIM/MIM console.

This library is broken down into different sections, making it easier to locate each piece of code, and contains the seeds of an
internal router.

Recommended usage is to break down your provisioning logic into "single-purpose" methods and then link these together via your
provisioning requirements.

For example, a method would exist of "provisionPersonToAD" that did not make any decisions about whether the user should exist or not,
but simply carried out the required functions to ensure that a user object was created (and placed) in the correct location in the
target Active Directory. 

At the same time, a provisionPerson method would make all of the provisioning decisions and would then trigger the required
methods to actually create accounts in connected systems as needed.

## Using the library

* Create a local copy by downloading / pulling mvtemplate
* Make sure that package definitions are upto date via nuget
* On the Visual Studio "File" Menu, select "Export Template"
* ensure that "project template" is selected and click "next"
* click "finish"

Create a new project, and the new template should be visible in the "C#" section.
  
