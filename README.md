# MRTK-Quest-Sample

Sample project for setting up with [MRTK-Quest](https://github.com/provencher/MRTK-Quest). Used only for educational purposes.

**As of [MRTK 2.5](https://microsoft.github.io/MixedRealityToolkit-Unity/version/releases/2.5.0/Documentation/ReleaseNotes.html), Oculus platforms are officially supported, leveraging the code that powers MRTK-Quest. Going forward, Microsoft will be maintaining Oculus support, and as such this repository will be archived.**

Some users seem to have issues with getting MRTK and the Oculus integration properly imported into their projects.

As such, I'll update this repository with the latest releases of MRTK, Oculus integration and MRTK-Quest, so that it can be used as a reference.

Further, to make this easier for people who struggle with Git to download, the repository **does not** use submodules, symlinks or git lfs.

Be sure to check out the MRTK-Quest FAQ in the [Readme](https://github.com/provencher/MRTK-Quest/blob/master/README.md).

Current setup:
- [MRTK-Quest](https://github.com/provencher/MRTK-Quest/releases/tag/v1.0.0) V1.1.0
- [MRTK](https://github.com/microsoft/MixedRealityToolkit-Unity) V2.4
- [Oculus Integration](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022) v19.1
- Unity 2019.4.8f1


## Note
This repo contains a few changes to MRTK v2.4 that serve to improve the Quest experience
- The standard shader has been adjusted to remove half and fixed variables to resolve compilation errors
- Icon textures have been adjusted to use tri-linear filtering, and to remove mipmaps as they cause the icons to disappear on Quest's lower res display.
