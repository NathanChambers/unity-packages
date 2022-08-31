﻿using System;

public interface IAuthService : IService {
	void Login(Action<IUser, Error> response);
	void Logout(Action<Error> response);
}
