using System;
using System.Collections.Generic;
using Castle.Windsor;

namespace Admin.Dashboard.Common.Domain
{
    public static class DomainEvents
    {
        [ThreadStatic]
        private static List<Delegate> _actions;

        private static IWindsorContainer _container;

        public static void Init(IWindsorContainer container)
        {
            _container = container;
        }

        public static void Register<T>(Action<T> callback) where T : DomainEvent
        {
            if (_actions == null)
            {
                _actions = new List<Delegate>();
            }

            _actions.Add(callback);
        }

        public static void ClearCallbacks()
        {
            _actions = null;
        }

        public static void Raise<T>(T args) where T : DomainEvent
        {
            if (_container != null)
            {
                foreach (var handler in _container.ResolveAll<Handles<T>>())
                {
                    handler.Handle(args);
                }
            }

            if (_actions != null)
            {
                foreach (var action in _actions)
                {
                    if (action is Action<T>)
                    {
                        ((Action<T>)action)(args);
                    }
                }
            }
        }

    }
}