﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelectable {

	void Select ();
	void Deselect();

	string UIInfo {
		get;
	}

	string type {
		get;
	}

}
