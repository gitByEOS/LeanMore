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
        public WinsComponent wins { get { return (WinsComponent)GetComponent(ComponentIds.Wins); } }

        public bool hasWins { get { return HasComponent(ComponentIds.Wins); } }

        public Entity AddWins(int newValue) {
            var component = CreateComponent<WinsComponent>(ComponentIds.Wins);
            component.value = newValue;
            return AddComponent(ComponentIds.Wins, component);
        }

        public Entity ReplaceWins(int newValue) {
            var component = CreateComponent<WinsComponent>(ComponentIds.Wins);
            component.value = newValue;
            ReplaceComponent(ComponentIds.Wins, component);
            return this;
        }

        public Entity RemoveWins() {
            return RemoveComponent(ComponentIds.Wins);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherWins;

        public static IMatcher Wins {
            get {
                if (_matcherWins == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Wins);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherWins = matcher;
                }

                return _matcherWins;
            }
        }
    }
}
