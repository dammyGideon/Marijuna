// Package block
import axios from 'axios';

// Get URL
import { GET_COUNTIES_URL } from './../constant';

export function getCounties() {
  return axios.get(GET_COUNTIES_URL);
}
