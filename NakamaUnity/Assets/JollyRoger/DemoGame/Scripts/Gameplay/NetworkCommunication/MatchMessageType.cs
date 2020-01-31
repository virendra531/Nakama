﻿/**
 * Copyright 2019 The Knights Of Unity, created by Piotr Stoch
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


namespace DemoGame.Scripts.Gameplay.NetworkCommunication.MatchStates
{
    /// <summary>
    /// Used to easily get op code for sending and reading match state messages
    /// </summary>
    public enum MatchMessageType
    {
        #region MATCH

        MatchStarted,

        MatchEnded,

        MatchReward,

        #endregion

        #region PLAYERS

        ActionPointsAdded,

        #endregion

        #region UNITS

        UnitSpawned,

        UnitMoved,

        UnitAttacked,

        #endregion

        #region SPELLS

        SpellActivated,

        #endregion

        #region CARDS

        StartingHand,

        CardPlayRequest,

        CardPlayed,

        CardCanceled,

        CardPlayDenial,

        #endregion

        #region EMOTES

        EmoteSendRequest,

        EmoteReceived,

        #endregion
    }
}
