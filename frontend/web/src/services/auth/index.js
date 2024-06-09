// Package Block
import axios from 'axios';
import { ONBOARD_NEW_URL, SIGN_IN_URL, FORGET_PASSWORD_URL } from '../constant';

// Onboarding New User
export function onboardingNewUser(payload) {
  return axios.post(ONBOARD_NEW_URL, payload);
}

// Sign In
export function signIn(payload) {
  return axios.post(SIGN_IN_URL, payload);
}

// Forget Password
export function forgetPassword(payload) {
  return axios.post(FORGET_PASSWORD_URL, payload);
}
