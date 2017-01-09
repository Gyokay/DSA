'use strict'

function binarySearch (arr, leftIndex, rightIndex, targetValue) {
	if (leftIndex > rightIndex) return -1

	let midIndex = Math.floor((leftIndex + rightIndex) / 2)

	if (arr[midIndex] === targetValue) return midIndex

	if (arr[midIndex] < targetValue) return binarySearch(arr, midIndex + 1, rightIndex, targetValue)
	if (arr[midIndex] > targetValue) return binarySearch(arr, leftIndex, midIndex - 1, targetValue)
}

module.exports = binarySearch
