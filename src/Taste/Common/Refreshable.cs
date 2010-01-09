/*
 * Copyright 2005 and onwards Sean Owen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Taste.Common
{

    /// <summary>
    /// Implementations of this interface have state that can be periodically refreshed. For example, an
    /// implementation instance might contain some pre-computed information that should be periodically
    /// refreshed. The {@link #Refresh()} method triggers such a refresh.</p>
    /// All Taste components implement this. In particular, {@link taste.Recommender.Recommender}s do.
    /// Callers may want to call {@link #refresh()} periodically to re-compute information throughout the system
    /// and bring it up to date, though this operation may be expensive.</p>
    ///
    /// @author Sean Owen
    /// </summary>
	public interface Refreshable 
    {
        /// <summary>
        /// Triggers "refresh" -- whatever that means -- of the implementation. The general contract is that
		/// any {@link Refreshable} should always leave itself in a consistent, operational state, and that
		/// the refresh atomically updates internal state from old to new.
        /// </summary>
		void Refresh();
	}
}