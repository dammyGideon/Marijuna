// src/views/SignIn.js

// Package Block
import React, { useState } from 'react';
import { Link } from 'react-router-dom';

import 'nprogress/nprogress.css'; // Ensure the CSS for nProgress is imported

// Custom Component Block
import { Button, Footer, InputField } from '../../../components';
import { Logo } from '../../../components/Logo';
import { validateEmail } from '../../../utils/helper';
import { useNProgress } from '../../../utils/customHooks/use-ngProgress';
import { signIn } from '../../../services/auth';
import { notification } from 'antd';

const SignIn = () => {
  useNProgress();

  const [step, setStep] = useState(1);
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isEmailValid, setIsEmailValid] = useState(true);

  const handleContinue = (event) => {
    event.preventDefault();
    if (email) {
      setStep(2);
    }
  };

  const handleLogin = async (event) => {
    event.preventDefault();
    const payload = {
      email: email,
      password: password,
    };
    try {
      const response = await signIn(payload);
      if (response.data.success) {
        notification.success({ message: response.data.message });
      }
      if (!response.data.success) {
        notification.success({ message: response.data.message });
      }
    } catch (error) {
      console.log('🚀 ~ handleLogin ~ error:', error);
    }
  };

  const handleEmailChange = (e) => {
    const newEmail = e.target.value;
    setEmail(newEmail);
    setIsEmailValid(validateEmail(newEmail));
  };

  return (
    <div className="container">
      <div className="main-form">
        <div className="logo-icon">
          <Logo />
        </div>
        <h1 className="form-title">Sign In</h1>
        {step === 1 ? (
          <>
            {!isEmailValid && (
              <p className="error-notification">Invalid Email</p>
            )}
            <InputField
              type="email"
              placeholder="Name@Work-Email.com"
              value={email}
              onChange={handleEmailChange}
            />
            <Button
              className="button"
              onClick={handleContinue}
              disabled={!email}
            >
              Continue
            </Button>
          </>
        ) : (
          <>
            <p className="error-notification">Invalid Password</p>
            <InputField
              type="email"
              placeholder="Name@Work-Email.com"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              disabled
            />
            <InputField
              type="password"
              placeholder="Password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
            />
            <Button className="button" onClick={handleLogin}>
              Sign In
            </Button>
          </>
        )}
        <div className="auth-links">
          <div>
            <Link to="/onboarding">Complete Onboarding</Link>
          </div>
          <div>
            <Link to="/reset-password">Reset Password</Link>
          </div>
        </div>
        <Footer />
      </div>
      <div className="auth-page-banner">
        {/* Background graphic goes here */}
      </div>
    </div>
  );
};

export default SignIn;
