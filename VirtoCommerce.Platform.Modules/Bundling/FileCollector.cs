using System.Collections.Generic;
using System.IO;
using VirtoCommerce.Platform.Core.VersionProvider;

namespace VirtoCommerce.Platform.Modules.Bundling
{
    public abstract class FileCollector : ICollector
    {
        private readonly IFileVersionProvider _fileVersionProvider;

        protected FileCollector(IFileVersionProvider fileVersionProvider)
        {
            _fileVersionProvider = fileVersionProvider;
        }

        protected abstract BundleMetadata GetMetadata();

        public ModuleFile[] Collect(bool isNeedVersionAppend)
        {
            var metadata = GetMetadata();

            return LoadModulesTargetPaths(metadata, isNeedVersionAppend);
        }

        protected virtual ModuleFile[] LoadModulesTargetPaths(BundleMetadata bundleMetadata, bool isNeedVersionAppend)
        {
            var result = new List<ModuleFile>();

            foreach (var moduleMetadata in bundleMetadata.ModulesMetadata)
            {

                if (moduleMetadata.VirtualPath == null)
                {
                    continue;
                }

                var targetPath = Path.Join(moduleMetadata.FullPhysicalModulePath, moduleMetadata.VirtualPath.Replace('/', Path.DirectorySeparatorChar));

                result.AddRange(
                    Handle(
                        targetPath,
                        bundleMetadata.BundleName,
                        bundleMetadata.VendorName,
                        moduleMetadata.ModuleName,
                        moduleMetadata.VirtualPath,
                        isNeedVersionAppend
                    )
                );
            }

            return result.ToArray();
        }

        private ModuleFile[] Handle(string targetPath, string applicationFilename, string vendorFilename, string moduleName, string virtualPath, bool isNeedVersionAppend)
        {
            var result = new List<ModuleFile>();

            if (Directory.Exists(targetPath))
            {
                var moduleFile = Path.Join(targetPath, applicationFilename);
                var moduleVendor = Path.Join(targetPath, vendorFilename);

                if (File.Exists(moduleFile))
                {
                    result.Add(new ModuleFile
                    {
                        WebPath = GetWebPath(moduleFile, moduleName, virtualPath),
                        Version = isNeedVersionAppend ? _fileVersionProvider.GetFileVersion(moduleFile) : string.Empty
                    });
                }

                if (File.Exists(moduleVendor))
                {
                    result.Add(new ModuleFile
                    {
                        WebPath = GetWebPath(moduleVendor, moduleName, virtualPath),
                        Version = isNeedVersionAppend ? _fileVersionProvider.GetFileVersion(moduleFile) : string.Empty,
                        IsVendor = true
                    });
                }
            }

            return result.ToArray();
        }

        private string GetWebPath(string filePath, string moduleName, string virtualPath)
        {
            return $"/Modules/$({moduleName})/{virtualPath}/{Path.GetFileName(filePath)}";
        }
    }
}