// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

namespace Vlingo.Xoom.Symbio
{
    public class StateBundle
    {
        public IState State { get; }
        
        public object? Object { get; }
        
        public StateBundle(IState state, object @object)
        {
            State = state;
            Object = @object;
        }

        public StateBundle(IState state) => State = state;
    }
}