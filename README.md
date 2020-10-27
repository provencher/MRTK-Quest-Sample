# MRTK-Quest-Sample

Sample project for setting up with [MRTK-Quest](https://github.com/provencher/MRTK-Quest). Used only for educational purposes.

**As of [MRTK 2.5](https://microsoft.github.io/MixedRealityToolkit-Unity/version/releases/2.5.0/Documentation/ReleaseNotes.html), Oculus platforms are officially supported, leveraging the code that powers MRTK-Quest.**

Some users seem to have issues with getting MRTK and the Oculus integration properly imported into their projects.

As such, this repo serves as an example setup for the official MRTK Oculus integration, using examples from MRTK-Quest. MRTK-Quest 1.2 is not a part of this project.

Further, to make this easier for people who struggle with Git to download, the repository **does not** use submodules, symlinks or git lfs.

Current setup:
- [MRTK](https://github.com/microsoft/MixedRealityToolkit-Unity) V2.5.1
- [Oculus Integration](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022) v20.1
- Unity 2019.4.12f1

Note:
- While developping with this sample, you may have to run this cript below, which will bind the Oculus prefab references to the OculusXRSDKDeviceManagerProfile  ![Install Oculus](https://user-images.githubusercontent.com/7420990/97363151-81ef0700-1878-11eb-9b49-0dc26e120a79.png)
