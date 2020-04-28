using System;
using LogoFX.Client.Bootstrapping;
using LogoFX.Client.Bootstrapping.Adapters.SimpleContainer;
using Samples.Specifications.Launcher.Shared;
using Samples.Specifications.Presentation.Contracts.Shell;
using Solid.Practices.Composition;

namespace Samples.Specifications.Launcher
{
    public sealed class AppBootstrapper : BootstrapperContainerBase<ExtendedSimpleContainerAdapter>
        .WithRootObjectAsContract<IShellViewModel>
    {
        private static readonly ExtendedSimpleContainerAdapter _container = new ExtendedSimpleContainerAdapter();

        public AppBootstrapper()
            : base(_container)
        {
        }

        public override CompositionOptions CompositionOptions => new CompositionOptions
        {
            Prefixes = Consts.Prefixes
        };

        protected override void OnExit(object sender, EventArgs e)
        {
            base.OnExit(sender, e);
            _container?.Dispose();
        }
    }
}