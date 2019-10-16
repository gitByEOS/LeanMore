//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        static readonly FinishedComponent finishedComponent = new FinishedComponent();

        public bool isFinished {
            get { return HasComponent(ComponentIds.Finished); }
            set {
                if (value != isFinished) {
                    if (value) {
                        AddComponent(ComponentIds.Finished, finishedComponent);
                    } else {
                        RemoveComponent(ComponentIds.Finished);
                    }
                }
            }
        }

        public Entity IsFinished(bool value) {
            isFinished = value;
            return this;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherFinished;

        public static IMatcher Finished {
            get {
                if (_matcherFinished == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Finished);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherFinished = matcher;
                }

                return _matcherFinished;
            }
        }
    }
}
