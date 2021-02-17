// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;
using System.Collections.Generic;
using Vlingo.Actors;
using Vlingo.Common;
using Vlingo.Symbio.Store.Dispatch;

namespace Vlingo.Symbio.Store.Journal
{
    public class Journal__Proxy<T> : IJournal<T>
    {
        private const string UsingRepresentation1 =
            "Using<TActor, TEntry, TState>(Vlingo.Actors.Stage, IDispatcher<IDispatchable<TEntry, TState>>, System.Object[])";

        private const string UsingRepresentation2 =
            "Using<TActor, TEntry, TState>(Vlingo.Actors.Stage, IEnumerable<IDispatcher<IDispatchable<TEntry, TState>>>, System.Object[])";

        private const string AppendRepresentation3 =
            "Append<TSource, TSnapshotState>(string, int, TSource, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string AppendRepresentation4 =
            "Append<TSource, TSnapshotState>(string, int, TSource, Vlingo.Symbio.Metadata, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string AppendWithRepresentation5 =
            "AppendWith<TSource, TSnapshotState>(string, int, TSource, TSnapshotState, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string AppendWithRepresentation6 =
            "AppendWith<TSource, TSnapshotState>(string, int, TSource, Vlingo.Symbio.Metadata, TSnapshotState, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string AppendAllRepresentation7 =
            "AppendAll<TSource, TSnapshotState>(string, int, IEnumerable<TSource>, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string AppendAllRepresentation8 =
            "AppendAll<TSource, TSnapshotState>(string, int, IEnumerable<TSource>, Vlingo.Symbio.Metadata, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string AppendAllWithRepresentation9 =
            "AppendAllWith<TSource, TSnapshotState>(string, int, IEnumerable<TSource>, TSnapshotState, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string AppendAllWithRepresentation10 =
            "AppendAllWith<TSource, TSnapshotState>(string, int, IEnumerable<TSource>, Vlingo.Symbio.Metadata, TSnapshotState, Vlingo.Symbio.Store.Journal.IAppendResultInterest, object)";

        private const string JournalReaderRepresentation11 = "JournalReader<TNewEntry>(string)";
        private const string StreamReaderRepresentation12 = "StreamReader(string)";

        private readonly Actor actor;
        private readonly IMailbox mailbox;

        public Journal__Proxy(Actor actor, IMailbox mailbox)
        {
            this.actor = actor;
            this.mailbox = mailbox;
        }

        public void Append<TSource, TSnapshotState>(string streamName, int streamVersion, TSource source,
            IAppendResultInterest interest, object @object) where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons1113662861 = __ =>
                    __.Append<TSource, TSnapshotState>(streamName, streamVersion, source, interest, @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons1113662861, null, AppendRepresentation3);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons1113662861, AppendRepresentation3));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendRepresentation3));
            }
        }

        public void Append<TSource, TSnapshotState>(string streamName, int streamVersion, TSource source,
            Metadata metadata, IAppendResultInterest interest, object @object) where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons397294566 = __ =>
                    __.Append<TSource, TSnapshotState>(streamName, streamVersion, source, metadata, interest, @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons397294566, null, AppendRepresentation4);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons397294566, AppendRepresentation4));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendRepresentation4));
            }
        }

        public void AppendWith<TSource, TSnapshotState>(string streamName, int streamVersion, TSource source,
            TSnapshotState snapshot, IAppendResultInterest interest, object @object) where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons1922720892 = __ =>
                    __.AppendWith(streamName, streamVersion, source, snapshot, interest, @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons1922720892, null, AppendWithRepresentation5);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons1922720892, AppendWithRepresentation5));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendWithRepresentation5));
            }
        }

        public void AppendWith<TSource, TSnapshotState>(string streamName, int streamVersion, TSource source,
            Metadata metadata, TSnapshotState snapshot, IAppendResultInterest interest, object @object)
            where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons1778464441 = __ =>
                    __.AppendWith(streamName, streamVersion, source, metadata, snapshot, interest, @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons1778464441, null, AppendWithRepresentation6);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons1778464441, AppendWithRepresentation6));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendWithRepresentation6));
            }
        }

        public void AppendAll<TSource, TSnapshotState>(string streamName, int fromStreamVersion,
            IEnumerable<TSource> sources, IAppendResultInterest interest, object @object) where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons1438749561 = __ =>
                    __.AppendAll<TSource, TSnapshotState>(streamName, fromStreamVersion, sources, interest, @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons1438749561, null, AppendAllRepresentation7);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons1438749561, AppendAllRepresentation7));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendAllRepresentation7));
            }
        }

        public void AppendAll<TSource, TSnapshotState>(string streamName, int fromStreamVersion,
            IEnumerable<TSource> sources, Metadata metadata, IAppendResultInterest interest, object @object)
            where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons1619280850 = __ =>
                    __.AppendAll<TSource, TSnapshotState>(streamName, fromStreamVersion, sources, metadata, interest,
                        @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons1619280850, null, AppendAllRepresentation8);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons1619280850, AppendAllRepresentation8));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendAllRepresentation8));
            }
        }

        public void AppendAllWith<TSource, TSnapshotState>(string streamName, int fromStreamVersion,
            IEnumerable<TSource> sources, TSnapshotState snapshot, IAppendResultInterest interest, object @object)
            where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons329572136 = __ =>
                    __.AppendAllWith(streamName, fromStreamVersion, sources, snapshot, interest, @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons329572136, null, AppendAllWithRepresentation9);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons329572136, AppendAllWithRepresentation9));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendAllWithRepresentation9));
            }
        }

        public void AppendAllWith<TSource, TSnapshotState>(string streamName, int fromStreamVersion,
            IEnumerable<TSource> sources, Metadata metadata, TSnapshotState snapshot, IAppendResultInterest interest,
            object @object) where TSource : Source
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons2042766341 = __ =>
                    __.AppendAllWith(streamName, fromStreamVersion, sources, metadata, snapshot, interest, @object);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons2042766341, null, AppendAllWithRepresentation10);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons2042766341, AppendAllWithRepresentation10));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, AppendAllWithRepresentation10));
            }
        }

        public ICompletes<IJournalReader<IEntry>?> JournalReader(string name)
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons1385350909 = __ => __.JournalReader(name);
                var completes = new BasicCompletes<IJournalReader<IEntry>>(actor.Scheduler);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons1385350909, completes, JournalReaderRepresentation11);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons1385350909, completes,
                        JournalReaderRepresentation11));
                return completes!;
            }

            actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, JournalReaderRepresentation11));
            return null!;
        }

        public ICompletes<IStreamReader<T>?> StreamReader(string name)
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons165823724 = __ => __.StreamReader(name);
                var completes = new BasicCompletes<IStreamReader<T>>(actor.Scheduler);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons165823724, completes, StreamReaderRepresentation12);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons165823724, completes,
                        StreamReaderRepresentation12));
                return completes!;
            }

            actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, StreamReaderRepresentation12));
            return null!;
        }

        public IJournal<T> Using<TActor, TEntry, TState>(Stage stage,
            IDispatcher<Dispatchable<TEntry, TState>> dispatcher, object[] additional)
            where TActor : Actor where TState : class, IState where TEntry : IEntry<T>
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons617400048 =
                    __ => __.Using<TActor, TEntry, TState>(stage, dispatcher, additional);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons617400048, null, UsingRepresentation1);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons617400048, UsingRepresentation1));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, UsingRepresentation1));
            }

            return null!;
        }

        public IJournal<T> Using<TActor, TEntry, TState>(Stage stage,
            IEnumerable<IDispatcher<Dispatchable<TEntry, TState>>> dispatchers, object[] additional)
            where TActor : Actor where TState : class, IState where TEntry : IEntry<T>
        {
            if (!actor.IsStopped)
            {
                Action<IJournal<T>> cons1486857027 =
                    __ => __.Using<TActor, TEntry, TState>(stage, dispatchers, additional);
                if (mailbox.IsPreallocated)
                    mailbox.Send(actor, cons1486857027, null, UsingRepresentation2);
                else
                    mailbox.Send(new LocalMessage<IJournal<T>>(actor, cons1486857027, UsingRepresentation2));
            }
            else
            {
                actor.DeadLetters?.FailedDelivery(new DeadLetter(actor, UsingRepresentation2));
            }

            return null!;
        }
    }
}